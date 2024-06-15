using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public class Model
    {
        private static double T = 0;
        public static double Time { get { return T; } }
        
        private static List<Agent> agents = new List<Agent>();
        static Shop shop;
        static ClientCustom clientCustom;
        static Agent activeAgent;
        public static int people = 0;

        public static int operators;

        public static void Cycle()
        {
            
            
            do
            {

                double tmin = double.MaxValue;
                activeAgent = null;
                foreach (Agent a in agents)
                {
                    double ta = a.getNextEventTime();
                    if (ta < tmin)
                    {
                        tmin = ta;
                        activeAgent = a;
                    }
                }
                T = tmin;
                if (activeAgent != null) 
                    activeAgent.ProccessEvent();
                people++;
            } while (!stopCondition(T, activeAgent));

        }

        public static void GO() 
        {
            shop = new Shop();
            clientCustom = new ClientCustom(shop);
            agents.Add(shop);
            agents.Add(clientCustom);
        }

        public static int queueCount()
        {
            return shop.getQueueSize();
        }
        public static int getBusyOperatorsCount()
        {
            return shop.getBusyOperatorsCount();
        }

        private static bool stopCondition(double t, Agent activeActor)
        {
            return (t < 100) || (activeActor == null);
        }
        public class Agent
        {

            public virtual double getNextEventTime()
            {
                return double.MaxValue;

            }
            public virtual void ProccessEvent()
            {

            }
        }

        public class ClientCustom : Agent //входящий поток
        {
            private Random rnd = new Random();
            public double lambda = 20;
            private double nexttimeclient = 0;
            private Shop shop;
            public ClientCustom(Shop shop)

            {
                this.shop = shop;
                nexttimeclient = simulateClientCustomTime();
            }

            private double simulateClientCustomTime()
            {
                return -Math.Log(rnd.NextDouble()) / lambda;
            }
            public override double getNextEventTime()
            {
                return nexttimeclient;
            }
            public override void ProccessEvent()
            {
                base.ProccessEvent();
                Customer customer = new Customer();
                shop.CustomerA(customer);
                nexttimeclient += simulateClientCustomTime();
            }
        }

        public class Customer : Agent 
        {

        }

        public class MyQueue : Agent
        {

            private Queue<Customer> queue = new Queue<Customer>();
            public void acceptCustomer(Customer customer)
            {
                queue.Enqueue(customer);
            }
            public bool hasCustomers()
            {
                return (queue.Count > 0);
            }
            public Customer takeCustomer()
            {
                return queue.Dequeue();
            }
            public int getQueueSize()
            {
                return queue.Count();
            }
        }


        public class Shop : Agent
        {
            private Service service = new Service(Model.operators);
            private MyQueue queue = new MyQueue();

            public void CustomerA(Customer customer)
            {
                if (service.hasFreeOp()) service.acceptCustomer(customer);
                else queue.acceptCustomer(customer);
            }

            public override double getNextEventTime()
            {
                return service.getNextEventTime();
            }
            public override void ProccessEvent()
            {
                service.ProccessEvent();
                if (queue.hasCustomers())
                {
                    Customer cus = queue.takeCustomer();
                    service.acceptCustomer(cus);
                }
            }
            internal int getBusyOperatorsCount()
            {
                return service.getBusyOperatorsCount();
            }
            public int getQueueSize()
            {
                return queue.getQueueSize();
            }

        }


        public class Service : Agent
        {
            private List<Operator> operators = new List<Operator>();
            private Operator activeOper = new Operator();
            public Service(int N)
            {
                for (int i = 0; i < N; i++)
                {
                    operators.Add(new Operator());
                }
            }

            public void acceptCustomer(Customer customer)
            {
                Operator op = findFreeOp();
                if (op != null) op.acceptCustomer(customer);
            }
            internal bool hasFreeOp()
            {
                Operator op = findFreeOp();
                return op != null;
            }

            private Operator findFreeOp()
            {
                foreach (Operator op in operators)
                    if (op.isFree()) return op;
                return null;
            }


            public override double getNextEventTime()
            {
                double tMin = double.MaxValue;
                activeOper = null;
                foreach (Operator op in operators)
                {
                    double tA = op.getNextEventTime();
                    if (tA < tMin)
                    {
                        tMin = tA;
                        activeOper = op;
                    }
                }
                return tMin;
            }
            public override void ProccessEvent()
            {
                if (activeOper != null)
                    activeOper.ProccessEvent();
            }

            internal int getBusyOperatorsCount()
            {
                int size = 0;
                foreach (Operator op in operators)
                    if (!op.isFree())
                        size++;
                return size;
            }


        }
        public class Operator : Agent
        {
            private double endOfSeviceTime = double.MaxValue;
            //private double endOfDerviceTime = double.MaxValue; //время окончания обслуживания
            private Customer customerInService = null;

            public double lambda = 5;
            private Random rnd = new Random();

            internal void acceptCustomer(Customer customer)
            {
                if (isFree())
                {
                    customerInService = customer;
                    endOfSeviceTime = Model.Time + simulateServiceTime();
                }
            }

            public bool isFree()//сервис обслуживание
            {
                return (customerInService == null);
            }


            private double simulateServiceTime()
            {
                return -Math.Log(rnd.NextDouble()) / lambda;
            }

            public override double getNextEventTime()
            {
                return endOfSeviceTime;
            }
            public override void ProccessEvent()
            {
                customerInService = null;
                endOfSeviceTime = double.MaxValue;
            }




        }

    }
}

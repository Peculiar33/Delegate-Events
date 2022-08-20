namespace Events
{

    internal class HospitalVisitaion  //publisher
    {
        public delegate void NotifyAdmini();
        public event NotifyAdmini NotifyOtherClasses;

        public void PatientsAvaliablity()
        {
            int pa = 5;

            //this is to confirm the number of Patients avaliable for their visits 

            {


                if (pa == 5)
                {
                    OnPatientsAvaliability();
                }
                else
                {
                    Console.WriteLine("Patients Avaliablity");
                }
                System.Threading.Thread.Sleep(10000);
                //when fraud is detected
                OnPatientsAvaliability();


            }
        }
        protected virtual void OnPatientsAvaliability()
        {
            NotifyOtherClasses?.Invoke();  //raise event
        }

    }


    public class ZionHospital  //subscriber
    {
        public void ActOnPatients()
        {
            var accPa = new HospitalVisitaion();
            accPa.NotifyOtherClasses += OnPatientsAvaliability;

            accPa.PatientsAvaliablity();
        }



        public void OnPatientsAvaliability()

        {
            Console.WriteLine("Alert the doctors on patients avaliable");
            Console.ReadLine();
        }
    }



}











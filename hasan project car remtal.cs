
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HasanProject
{






    class Program
    {
        int fare;
        int gear_fear;
        string days;
        string name;
        int total;
        string phone;
        string cnic;
        string address;
        int parse_int_day;

        static void Main(string[] args)
        {
            Program p = new Program();
            p.welcome();


        }

        public void welcome()
        {
            Console.WriteLine("********************\n\n********** WELCOME **********\n*************** TO ***************\n***** CAR RENTAL PROJECT *****\n\n********************");

            personalInformation();
        }
        public void personalInformation()
        {
            Console.Write("*****PERSONAL INFORMATION*****");
            Console.Write("\n\nNAME : ");
             name = Convert.ToString(Console.ReadLine());
            phoneNo();
            cnicNo();
            Console.Write("\n\nHOME ADDRESS : ");
            address = Convert.ToString(Console.ReadLine());

            requirment();
            //gearTransmission();
            //  Final_Fare();
            //submit();


        }


            
        
        public void phoneNo()
        {
            Console.Write("\n\nPHONE NO. : ");

            phone = Console.ReadLine();

            long phn_no_digit;
            bool isNumeric = long.TryParse(phone, out phn_no_digit);

            if (!isNumeric)
            {
                Console.WriteLine("\n\n-----Incorrect value!! Plese enter numeric value-----");
                Console.Clear();
                phoneNo();

            }


            if (phone.Length < 11 || phone.Length > 11)
            {
                Console.Write("\n\n-----PLEASE ENTER 11 DIGIT VALUE-----");
                Console.Clear();
                phoneNo();
            }



        }


        public void cnicNo()
        {
            Console.Write("CNIC : ");
            cnic = Console.ReadLine();
            long cnic_no_digit;
            bool isNumeric = long.TryParse(cnic, out cnic_no_digit);

            if (!isNumeric)
            {
                Console.WriteLine("-----Incorrect value!! Plese enter numeric value-----");
                Console.Clear();
                cnicNo();
            }
            if (cnic.Length < 13 || cnic.Length > 13)
            {
                Console.Write("------PLEASE ENTER 13 DIGIT VALUE-----");
                Console.Clear();
                cnicNo();
            }

        }
        public void requirment()
        {
            Console.Write("\n\nENTER MAKE \n Press 1 for HONDA \n Press 2 for TOYOTA \n Press 3 for NISSAN \n Press 4 for AUDI \n Press 5 for DIAHATSU \n Press 6 for SUZUKI \n ");
            string make = Convert.ToString(Console.ReadLine());
            switch (make)
            {

                case "1":
                carcategory1:
                    //1 for honda
                    //Console.Write("HONDA");
                    Console.Write("\n\nEnter Model \n Press 1 for CIVIC \n Press 2 for CITY \n Press 3 for FIT \n Press 4 for BR-V \n Press 5 for CROSSROAD \n Press 6 for AIRWAVE \n Press 7 for VEZEL \n Press 8 for ACCORD \n Press 9 for CR-V \n Press 10 for INSIGHT \n ");
                    string 
                        model = Convert.ToString(Console.ReadLine());

                    switch (model)
                    {
                        case "1":
                            Console.Write("\nCIVIC");
                            fare = 8000;

                            break;
                        case "2":
                            Console.Write("\nCITY");
                            fare = 4000;
                            break;
                        case "3":
                            Console.Write("\nFIT");
                            fare = 3000;
                            break;
                        case "4":
                            Console.Write("\nBR-V");
                            fare = 6500;
                            break;
                        case "5":
                            Console.Write("\nCROSSROAD");
                            fare = 7000;
                            break;
                        case "6":
                            Console.Write("\nAIRWAVE");
                            fare = 3500;
                            break;
                        case "7":
                            Console.Write("\nVEZEL");
                            fare = 7000;
                            break;
                        case "8":
                            Console.Write("\nACCORD");
                            fare = 10000;
                            break;
                        case "9":
                            Console.Write("\nCR-V");
                            fare = 8000;
                            break;
                        case "10":
                            Console.Write("\nINSIGHT");
                            fare = 5000;
                            break;
                        default:
                            Console.Write("-----PLEASE SELECT CORRECT OPTION-----");
                            Console.ReadLine();
                            Console.Clear();
                            goto carcategory1;

                            break;


                    }

                    break;
                case "2":
                carcategory2:
                    //1 for TOYOTA
                    //Console.Write("HONDA");
                    Console.Write("\n\nEnter Model \n Press 1 for COROLLA \n Press 2 for REVO \n Press 3 for VIGO \n Press 4 for VITZ \n Press 5 for LAND-CRUISER \n Press 6 for PRADO \n Press 7 for GRANDE \n Press 8 for PASSO \n Press 9 for AQUA \n Press 10 for HIACE \n Press 11 for COASTER \n Press 12 for TUNDRA \n Press 13 for PROBOX \n Press 14 for CH-R \n Press 15 for CAMRI \n ");
                    string model1 = Convert.ToString(Console.ReadLine());

                    switch (model1)
                    {
                        case "1":
                            Console.Write("\nCOROLLA");
                            fare = 4000;
                            break;
                        case "2":
                            Console.Write("\nREVO");
                            fare = 15000;
                            break;
                        case "3":
                            Console.Write("\nVIGO");
                            fare = 10000;
                            break;
                        case "4":
                            Console.Write("\nVITZ");
                            fare = 4000;
                            break;
                        case "5":
                            Console.Write("\nLAND-CRUISER");
                            fare = 20000;
                            break;
                        case "6":
                            Console.Write("\nPRADO");
                            fare = 18000;
                            break;
                        case "7":
                            Console.Write("\nGRANDE");
                            fare = 5000;
                            break;
                        case "8":
                            Console.Write("\nPASSO");
                            fare = 5000;
                            break;
                        case "9":
                            Console.Write("\nAQUA");
                            fare = 7000;
                            break;
                        case "10":
                            Console.Write("\nHIACE");
                            fare = 10000;
                            break;
                        case "11":
                            Console.Write("\nCOASTER");
                            fare = 15000;
                            break;
                        case "12":
                            Console.Write("\nFORTUNER");
                            fare = 18000;
                            break;
                        case "13":
                            Console.Write("\nPROBOX");
                            fare = 2500;
                            break;
                        case "14":
                            Console.Write("\nCH-R");
                            fare = 6000;
                            break;
                        case "15":
                            Console.Write("\nCAMRY");
                            fare = 8000;
                            break;
                        default:
                            Console.Write("-----PLEASE SELECT CORRECT OPTION-----");
                            Console.ReadLine();
                            Console.Clear();
                            goto carcategory2;

                            break;
                    }
                    break;
                case "3":
                carcategory3:
                    //1 for NISSAN
                    //Console.Write("HONDA");
                    Console.Write("\n\nEnter Model \n Press 1 for DAYZ \n Press 2 for JUKE \n Press 3 for 350Z \n Press 4 for PATROL \n Press 5 for SKYLINE \n Press 6 for SANTRA \n Press 7 for CLIPPER \n Press 8 for GT-R \n Press 9 for ROOX \n");
                    string model2 = Convert.ToString(Console.ReadLine());

                    switch (model2)
                    {
                        case "1":
                            Console.Write("\nDAYZ");
                            fare = 3500;
                            break;
                        case "2":
                            Console.Write("\nJUKE");
                            fare = 7000;
                            break;
                        case "3":
                            Console.Write("\n350Z");
                            fare = 15000;
                            break;
                        case "4":
                            Console.Write("\nPATROL");
                            fare = 6000;
                            break;
                        case "5":
                            Console.Write("\nSKYLINE");
                            fare = 20000;
                            break;
                        case "6":
                            Console.Write("\nSANTRA");
                            fare = 6000;
                            break;
                        case "7":
                            Console.Write("\nCLIPPER");
                            fare = 4000;
                            break;
                        case "8":
                            Console.Write("\nGT-R");
                            fare = 17000;
                            break;
                        case "9":
                            Console.Write("\nROOX");
                            fare = 4500;
                            break;
                        default:
                            Console.Write("\nPLEASE SELECT CORRECT OPTION");
                            Console.ReadLine();
                            Console.Clear();
                            goto carcategory3;
                            break;
                    }
                    break;
                case "4":
                carcategory4:
                    //1 for AUDI
                    //Console.Write("HONDA");
                    Console.Write("\n\nEnter Model \n Press 1 for A3 \n Press 2 for A4 \n Press 3 for A5 \n ");
                    string model3 = Convert.ToString(Console.ReadLine());

                    switch (model3)
                    {
                        case "1":
                            Console.Write("\nA3");
                            fare = 10000;
                            break;
                        case "2":
                            Console.Write("\nA4");
                            fare = 15000;
                            break;
                        case "3":
                            Console.Write("\nA5");
                            fare = 20000;
                            break;
                        default:
                            Console.Write("-----PLEASE SELECT CORRECT OPTION-----");
                            Console.ReadLine();
                            Console.Clear();
                            goto carcategory4;

                            break;
                    }
                    break;
                case "5":
                carcategory5:
                    //1 for DIAHATSU
                    //Console.Write("HONDA");
                    Console.Write("Enter Model \n Press 1 for MIRA \n Press 2 for HIJET \n Press 3 for MOVE \n Press 4 for CUORE \n Press 5 for BOON \n Press 6 for CAST \n Press 7 for TANTO \n Press 8 for COPEN \n ");
                    string model4 = Convert.ToString(Console.ReadLine());

                    switch (model4)
                    {
                        case "1":
                            Console.Write("\nMIRA");
                            fare = 5000;
                            break;
                        case "2":
                            Console.Write("\nHIJET");
                            fare = 4000;
                            break;
                        case "3":
                            Console.Write("\nMOVE");
                            fare = 4500;
                            break;
                        case "4":
                            Console.Write("\nCUORE");
                            fare = 3000;
                            break;
                        case "5":
                            Console.Write("\nBOON");
                            fare = 3700;
                            break;
                        case "6":
                            Console.Write("\nCAST");
                            fare = 4500;
                            break;
                        case "7":
                            Console.Write("\nTANTO");
                            fare = 5000;
                            break;
                        case "8":
                            Console.Write("\nCOPEN");
                            fare = 9000;
                            break;
                        default:
                            Console.Write("-----PLEASE SELECT CORRECT OPTION-----");
                            Console.ReadLine();
                            Console.Clear();
                            goto carcategory5;

                            break;
                    }
                    break;
                case "6":
                carcategory6:
                    //1 for SUZUKI
                    //Console.Write("HONDA");
                    Console.Write("Enter Model \n Press 1 for HUSTLER \n Press 2 for BOLAN \n Press 3 for MEHRAN \n Press 4 for AP-V \n Press 5 for ALTO \n Press 6 for CULTUS \n Press 7 for SWIFT \n Press 8 for VITARA \n Press 9 for CIAZ \n Press 10 for WAGON-R \n ");
                    string model5 = Convert.ToString(Console.ReadLine());

                    switch (model5)
                    {
                        case "1":
                            Console.Write("\nHUSTLER");
                            fare = 4500;
                            break;
                        case "2":
                            Console.Write("\nBOLAN");
                            fare = 3000;
                            break;
                        case "3":
                            Console.Write("\nMEHRAN");
                            fare = 2500;
                            break;
                        case "4":
                            Console.Write("\nAPV");
                            fare = 7000;
                            break;
                        case "5":
                            Console.Write("\nALTO");
                            fare = 5000;
                            break;
                        case "6":
                            Console.Write("\nCULTUS");
                            fare = 4500;
                            break;
                        case "7":
                            Console.Write("\nSWIFT");
                            fare = 6000;
                            break;
                        case "8":
                            Console.Write("\nVITARA");
                            fare = 8000;
                            break;
                        case "9":
                            Console.Write("\nCIAZ");
                            fare = 6000;
                            break;
                        case "10":
                            Console.Write("\nWAGON-R");
                            fare = 4500;
                            break;
                        default:
                            Console.Write("\n\n-----PLEASE SELECT CORRECT OPTION-----");
                            Console.ReadLine();
                            Console.Clear();
                            goto carcategory6;

                            break;
                    }
                    break;
                default:
                    Console.Write("\n\n-----PLEASE ENTER CORRECT VALUE-----");
                    Console.ReadLine();
                    Console.Clear();
                    requirment();
                    break;


            }
            No_Of_Days();


        }
        public void No_Of_Days()
        {
            Console.Write("\nENTER DAYS FOR CAR RENT :");
            days = Console.ReadLine();
            int No_of_days;
            bool isNumeric = int.TryParse(days, out No_of_days);

            if (!isNumeric)
            {
                Console.WriteLine("\n\n-----Incorrect value!! Plese enter numeric value-----");
                Console.ReadLine();
                Console.Clear();
                No_Of_Days();

            }
            else

            {
                parse_int_day = Convert.ToInt32(days);
            }


            gearTransmission();

        }
        public void gearTransmission()
        {
            Console.WriteLine("\nAUTOMATIC / MANUAL \n Press 1 for AUTOMATIC \n Press 2 for Manual \n");
            string gear = Convert.ToString(Console.ReadLine());
            switch (gear)
            {
                case "1":
                    //1 for automatic
                    gear_fear = 2000;
                    //Console.Write("\nAUTOMATIC");
                    break;
                case "2":
                    //2 for manual
                    gear_fear = 1000;
                   // Console.Write("\nMANUAL");
                    break;
                default:
                    Console.Write("\n\n-----PLEASE ENTER CORRECT VALUE-----");
                    Console.ReadLine();
                    Console.Clear();
                    gearTransmission();

                    break;
            }
            Console.ReadLine();
            Final_Fare();



        }
        public void Final_Fare()
        {

            total = (fare * parse_int_day) + gear_fear;
            Console.Write("\n\n*****YOUR FINAL FARE IS :" + total + "*****");
            Console.ReadLine();
            submit();

        }
        public void submit()
        {
            submit_category:
            Console.Write("***** DO YOU WANT A RECIEPT ***** \n*** Press Y for YES ***\n*** Press N for NO ***\n : ");
            string submit = Convert.ToString(Console.ReadLine());
            if (submit == "y" || submit == "Y")
            {
                Console.WriteLine("-------------------THANK YOU FOR RENTING----------------------------------\n \n \n \n");


                // To write a line in buffer 
                Console.WriteLine("                   | ------------------------------------------------");
                Console.WriteLine("                   | NAME : " + name + " |");
                Console.WriteLine("                   |------------------------------------------------");
                Console.WriteLine("                   | PHONE NO. : " + phone + "| ");
                Console.WriteLine("                   |------------------------------------------------");
                Console.WriteLine("                   | CNIC NO. : " + cnic + "| ");
                Console.WriteLine("                   |------------------------------------------------");
                Console.WriteLine("                   | ADDRESS : " + address + "| ");
                Console.WriteLine("                   |------------------------------------------------");
                Console.WriteLine("                   | TOTAL RENT : " + total + "| ");
                Console.WriteLine("                   |-----------------------------------------------");
                Console.WriteLine("                   | CAR RENTED DAYS : " + days + "| ");
                Console.WriteLine("                   |------------------------------------------------");
                DateTime now = DateTime.Now;
                Console.Write(now.ToString("f"));

                Console.WriteLine("------------------- HAVE A NICE DAY :) ----------------------------------\n \n \n \n");
                Console.ReadLine();

                reciept();
                
            }
            
            if (submit == "N" || submit == "n")
            {
                form_category:
                Console.Write("--------DO YOU WANT TO FILL THIS FORM AGAIN ?---------\n Press Y for YES \n Press N for NO ");
                string againForm = Convert.ToString(Console.ReadLine());
                if (againForm == "Y" || againForm == "y")
                {
                    Console.Clear();
                    welcome();
                }
               
                if (againForm == "N" || againForm == "n")
                {
                    Console.WriteLine("-----THANKS FOR VISITING-----");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("-----PLEASE ENTER CORRECT VALUE-----");
                    goto form_category;
                }


            }
            
                 else
                {
                    Console.WriteLine("-----PLEASE ENTER CORRECT VALUE-----");
                    goto submit_category;
                }
            

        }
        public void reciept()
        {
            //    FileStream reciept1 = new FileStream("C:\\Users\\user\\Desktop\\HasanProject/" + name, FileMode.Create, FileAccess.Write);

            FileStream receipt = new FileStream("D:\\ConsoleApplication52\\.txt",FileMode.Append,FileAccess.Write);
            StreamWriter sw = new StreamWriter(receipt); 

            // To write on the console screen 
            sw.WriteLine("-------------------THANK YOU FOR RENTING----------------------------------\n \n \n \n");


            // To write a line in buffer 
            sw.WriteLine("                   | ------------------------------------------------");
            sw.WriteLine("                   | NAME : " + name +  " |");
            sw.WriteLine("                   |------------------------------------------------");
            sw.WriteLine("                   | PHONE NO. : " + phone + "| ");
            sw.WriteLine("                   |------------------------------------------------");
            sw.WriteLine("                   | CNIC NO. : " + cnic + "| ");
            sw.WriteLine("                   |------------------------------------------------");
            sw.WriteLine("                   | ADDRESS : " + address + "| ");
            sw.WriteLine("                   |------------------------------------------------");
            sw.WriteLine("                   | TOTAL RENT : " + total + "| ");
            sw.WriteLine("                   |-----------------------------------------------");
            sw.WriteLine("                   | CAR RENTED DAYS : " + days + "| "  );
            sw.WriteLine("                   |------------------------------------------------");
            DateTime now = DateTime.Now;
            sw.WriteLine(now.ToString("f"));

            sw.WriteLine("------------------- HAVE A NICE DAY :) ----------------------------------\n \n \n \n");

            // To write in output stream 
            sw.Flush();
            Console.Clear();
            welcome(); 
        }








    }
}
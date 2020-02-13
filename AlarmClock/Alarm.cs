using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClock
{
    class Alarm
    {
        //Member Variables
        public string clockTime;
        public string alarmTime;
        public bool alarmSwitch;
        public string stationName;

        public Alarm() //Constructor
        {
            clockTime = "6:00pm" ;
            alarmTime = "5:00am";
            alarmSwitch = false;
            stationName = "95.1";
        }

        //Methods
        public void ChangeClockTime() //changes the clock based on user input
        {
            clockTime = Console.ReadLine();
            Console.WriteLine("Your current time has been changed to - " + clockTime + "\n");
        }

        public void ChangeAlarmTime()//changes the alarm time based on user input and defaults it to on when changed
        {
            alarmTime = Console.ReadLine();
            Console.WriteLine("Your Alarm time has been changed to - " + alarmTime + "\n");
        }

        public void AlarmSwitch() //changes the alarm on/off status based on user input
        {
            alarmSwitch = !alarmSwitch;
            Console.WriteLine("Your Alarm is now on.\n");
        }

        public void ChangeRadioStation() //changes the clocks current radio station based on user input
        {
            stationName = Console.ReadLine();
            Console.WriteLine("Your station has been changed to " + stationName);
        }

        public void ClockInformationDefault() //Displays the default clock build (beginning of program)
        {
            Console.WriteLine("This is your new Clock with these default settings! \n");
            Console.WriteLine(clockTime);
            Console.WriteLine(alarmTime);
            Console.WriteLine(alarmSwitch);
            Console.WriteLine(stationName);
            Console.WriteLine("\n");
        }

        public void ClockInformation() //Displays the clock with updated settings(end of prgram)
        {
            Console.WriteLine("This is your new Clock with your settings! \n");
            Console.WriteLine(clockTime);
            Console.WriteLine(alarmTime);
            Console.WriteLine(alarmSwitch);
            Console.WriteLine(stationName);
            Console.WriteLine("\n");
        }

        public void Initialize() //Runs all methods
        {
            //Displays default clock information
            ClockInformationDefault();

            //Clock time and changing clock time
            Console.WriteLine("Here is your current Time - " + clockTime + " Would you like to change it? (Type Y/N)");
            string changeTimeInput = Console.ReadLine();
            switch (changeTimeInput)
            {
                case "Y":
                    Console.WriteLine("\nPlease enter in your new current time...");
                    ChangeClockTime();
                    break;
                case "N":
                    Console.WriteLine("\nLets move on then.\n");
                    break;
                default:
                    Console.WriteLine("\nThat was not a valid response, no changes made.\n");
                    break;
            }

            //Alarm time and changing alarm time and its on/off status
            Console.WriteLine("Here is your current Alarm Time - " + alarmTime + " Your alarm is currently " + alarmSwitch);
            Console.WriteLine("Would you like to change your alarm time? (Type Y/N)");
            string changeAlarmTimeInput = Console.ReadLine();
            switch (changeAlarmTimeInput)
            {
                case "Y":
                    Console.WriteLine("Please enter in your desired alarm time...\n");
                    ChangeAlarmTime();
                    AlarmSwitch();
                    break;
                case "N":
                    Console.WriteLine("Would you like to turn on your alarm? (Type Y/N)");
                    string turnAlarmOn = Console.ReadLine();
                    if (turnAlarmOn == "Y")
                    {
                        AlarmSwitch();
                    }
                    else
                    {
                        Console.WriteLine("Lets move on then.\n");
                    }
                    break;
                default:
                    Console.WriteLine("that was not a valid response, no changes made.\n");
                    break;
            }

            //Radio station and changing the station
            Console.WriteLine("Here is your current Radio Station - " + stationName);
            Console.WriteLine("Would you like to change your radio station? (Type Y/N)");
            string changeRadioStation = Console.ReadLine();
            switch (changeRadioStation)
            {
                case "Y":
                    ChangeRadioStation();
                    Console.WriteLine("Your station has been changed to " + stationName);
                    break;
                case "N":
                    Console.WriteLine("The station was unchanged");
                    break;
            }

            //Displays updated clock information
            ClockInformation();

            Console.ReadLine();
        }
    }
}

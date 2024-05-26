using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AirlineSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Default Admin
            CredentialsBL adminDummy = new CredentialsBL("Hashim", "123");
            CredentialsDL.addAdmin(adminDummy);

            //check
            FlightsDataBL dummy = new FlightsDataBL("PakChina", "5:00pm", "germany to pakistan", 120, 50);
            FlightsDataBL dummy1 = new FlightsDataBL("PakAmerica", "4:00pam", "italy to pakistan", 150, 30);
            FlightsDataDL.addFlight(dummy);
            FlightsDataDL.addFlight(dummy1);

            //Headers.interFace();
            while (true)
            {
                //Headers.header();
                //string option = MenusUI.mainMenu();
                string option = "2";
                if(option == "1")
                {
                    Headers.header();
                    //bool check = CredentialsDL.checkAdmin(CredentialsUI.takeInput());
                    bool check = true;
                    if (check == true)
                    {
                        //CredentialsUI.signIn();
                        //SideFunctions.clearScreen();
                        while(true)
                        {
                            Headers.header();
                            string menuOption = MenusUI.adminMenu();
                            if(menuOption == "1")
                            {
                                Headers.header();
                                FlightsDataDL.addFlight(FlightsDataUI.takeInput());
                                FlightsDataUI.addedFlight();
                                SideFunctions.clearScreen();
                            }
                            else if (menuOption == "2")
                            {
                                Headers.header();
                                FlightsDataUI.displayFlights();
                                int input = FlightsDataUI.selectNumber();
                                bool valid = FlightsDataDL.checkValidity(input);
                                if (valid == true)
                                {
                                    Headers.header();
                                    FlightsDataBL flight = FlightsDataDL.checkFlight(input);
                                    FlightsDataUI.dispalySpecificFlight(flight);
                                    double price = FlightsDataUI.enterPrice();
                                    FlightsDataDL.updatePrice(flight, price);
                                    Headers.header();
                                    FlightsDataUI.dispalySpecificFlight(flight);
                                    FlightsDataUI.updatedPrice();
                                    SideFunctions.clearScreen();
                                }
                                else
                                {
                                    FlightsDataUI.inValidFlightNumber();
                                    SideFunctions.clearScreen();
                                }

                            }
                            else if (menuOption == "3")
                            {
                                Headers.header();
                                FlightsDataUI.displayFlights();
                                SideFunctions.clearScreen();
                            }
                            else if (menuOption == "4")
                            {
                                Headers.header();
                                FlightsDataUI.displayFlights();
                                int input = FlightsDataUI.selectNumber();
                                bool valid = FlightsDataDL.checkValidity(input);
                                if (valid == true)
                                {
                                    Headers.header();
                                    FlightsDataBL flight = FlightsDataDL.checkFlight(input);
                                    FlightsDataUI.dispalySpecificFlight(flight);
                                    string time = FlightsDataUI.enterTime();
                                    FlightsDataDL.updateTime(flight, time);
                                    Headers.header();
                                    FlightsDataUI.dispalySpecificFlight(flight);
                                    FlightsDataUI.updatedTime();
                                    SideFunctions.clearScreen();
                                }
                                else
                                {
                                    FlightsDataUI.inValidFlightNumber();
                                    SideFunctions.clearScreen();
                                }

                            }
                            else if (menuOption == "5")
                            {
                                Headers.header();
                                FlightsDataUI.displayFlights();
                                int input = FlightsDataUI.selectNumber();
                                bool valid = FlightsDataDL.checkValidity(input);
                                if (valid == true)
                                {
                                    Headers.header();
                                    FlightsDataDL.cancelFlight(input);
                                    Headers.header();
                                    FlightsDataUI.displayFlights();
                                    FlightsDataUI.cancledFlight();
                                    SideFunctions.clearScreen();
                                }
                                else
                                {
                                    FlightsDataUI.inValidFlightNumber();
                                    SideFunctions.clearScreen();
                                }

                            }
                            else if (menuOption == "6")
                            {
                                Headers.header();
                                FlightsDataUI.displayFlights();
                                int input = FlightsDataUI.selectNumber();
                                bool valid = FlightsDataDL.checkValidity(input);
                                if (valid == true)
                                {
                                    Headers.header();
                                    FlightsDataBL flight = FlightsDataDL.checkFlight(input);
                                    FlightsDataUI.dispalySpecificFlight(flight);
                                    string route = FlightsDataUI.enterRoute();
                                    FlightsDataDL.updateRoute(flight, route);
                                    Headers.header();
                                    FlightsDataUI.dispalySpecificFlight(flight);
                                    FlightsDataUI.updatedRoute();
                                    SideFunctions.clearScreen();
                                }
                                else
                                {
                                    FlightsDataUI.inValidFlightNumber();
                                    SideFunctions.clearScreen();
                                }

                            }
                            else if (menuOption == "7")
                            {
                                Headers.header();
                                FlightsDataUI.displayFlights();
                                int input = FlightsDataUI.selectNumber();
                                bool valid = FlightsDataDL.checkValidity(input);
                                if (valid == true)
                                {
                                    Headers.header();
                                    FlightsDataBL flight = FlightsDataDL.checkFlight(input);
                                    FlightsDataUI.dispalySpecificFlight(flight);
                                    int quantity = FlightsDataUI.enterQuantity();
                                    FlightsDataDL.updateQuantity(flight, quantity);
                                    Headers.header();
                                    FlightsDataUI.dispalySpecificFlight(flight);
                                    FlightsDataUI.updatedQuantity();
                                    SideFunctions.clearScreen();
                                }
                                else
                                {
                                    FlightsDataUI.inValidFlightNumber();
                                    SideFunctions.clearScreen();
                                }

                            }
                            else if (menuOption == "8")
                            {
                                Headers.header();
                                CredentialsBL admin = CredentialsUI.takeInput();
                                bool test = CredentialsDL.checkAdmin(admin);
                                if(test == true)
                                {
                                    CredentialsUI.alreadyExists();
                                    SideFunctions.clearScreen();
                                }
                                else
                                {
                                    CredentialsDL.addAdmin(admin);
                                    CredentialsUI.addedAdmin();
                                    SideFunctions.clearScreen();
                                }
                            }
                            else if(menuOption == "0")
                            {
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine();
                        CredentialsUI.wrongCredentials();
                        SideFunctions.clearScreen();
                    }
                }

                else if (option == "2")
                {
                    while(true)
                    {
                        Headers.header();
                        //string input = MenusUI.userSign();
                        string input = "1";
                        if (input == "1")
                        {
                            Headers.header();
                            //CredentialsBL user = CredentialsUI.takeInput();
                            //bool test = CredentialsDL.checkUser(user);
                            bool test = true;
                            if(test == true)
                            {
                                //CredentialsUI.signedIn();
                                //SideFunctions.clearScreen();
                                while(true)
                                {
                                    Headers.header();
                                    string value = MenusUI.userMenu();
                                    if(value == "1")
                                    {
                                        Headers.header();
                                        UserFlightsUI.displayFlights();
                                        int num = FlightsDataUI.selectNumber();
                                        bool valid = FlightsDataDL.checkValidity(num);
                                        if(valid == true)
                                        {
                                            FlightsDataBL flight = FlightsDataDL.checkFlight(num);
                                            int tickets = UserFlightsUI.enterTickets();
                                            bool check = FlightsDataDL.checkTickets(tickets, flight);
                                            if(check == true)
                                            {
                                                Headers.header();
                                                UserFlightsBL userFlight = new UserFlightsBL(tickets, flight);
                                                UserFlightsUI.dispalySpecificFlight(userFlight);
                                                string confirm = UserFlightsUI.confirmTickets();
                                                if (confirm == "1")
                                                {
                                                    bool checkValid = UserFlightsDL.checkValid(userFlight);
                                                    if(checkValid == true)
                                                    {
                                                        UserFlightsBL checkFlight = UserFlightsDL.checkFlight(userFlight);
                                                        UserFlightsDL.addTickets(tickets, checkFlight);
                                                        FlightsDataDL.decrementTickets(tickets, flight);
                                                        UserFlightsUI.thanksOnBought(tickets);
                                                        SideFunctions.clearScreen();
                                                    }
                                                    else
                                                    {
                                                        UserFlightsDL.addUserFlight(userFlight);
                                                        FlightsDataDL.decrementTickets(tickets, flight);
                                                        UserFlightsUI.thanksOnBought(tickets);
                                                        SideFunctions.clearScreen();
                                                    }
                                                }
                                                else
                                                {
                                                    UserFlightsUI.thanks();
                                                    SideFunctions.clearScreen();
                                                }
                                            }
                                            else
                                            {
                                                UserFlightsUI.outOfOrder(flight);
                                                SideFunctions.clearScreen();
                                            }
                                        }
                                        else
                                        {
                                            FlightsDataUI.inValidFlightNumber();
                                            SideFunctions.clearScreen();
                                        }

                                    }
                                    else if (value == "2")
                                    {
                                        Headers.header();
                                        UserFlightsUI.displayBoughtFlights();
                                        SideFunctions.clearScreen();
                                    }
                                    else if (value == "3")
                                    {
                                        Headers.header();
                                        UserFlightsUI.displayBoughtFlights();
                                        int num = FlightsDataUI.selectNumber();
                                        bool valid = UserFlightsDL.checkValidity(num);
                                        UserFlightsBL checkFlight = UserFlightsDL.checkFlight(num);
                                        if (valid == true)
                                        {
                                            Headers.header();
                                            UserFlightsUI.dispalySpecificFlight(checkFlight);
                                            int tickets = UserFlightsUI.enterRefundTickets();
                                            bool checkTickets = UserFlightsDL.checkBoughtTickets(tickets, checkFlight.Tickets);
                                            if(checkTickets == true)
                                            {
                                                UserFlightsDL.refundTickets(tickets, checkFlight);
                                                FlightsDataBL flight = FlightsDataDL.checkFlight(checkFlight.FlightName);
                                                FlightsDataDL.incrementTickets(tickets, flight);
                                                UserFlightsDL.decrementBoughtTickets(tickets, checkFlight);
                                                UserFlightsDL.removeUserFlight(num, checkFlight.Tickets);
                                                UserFlightsUI.thanksOnRefund(tickets);
                                                SideFunctions.clearScreen();
                                            }
                                            else
                                            {
                                                UserFlightsUI.invalidBoughtTickets(checkFlight.Tickets);
                                                SideFunctions.clearScreen();
                                            }
                                        }
                                        else
                                        {
                                            FlightsDataUI.inValidFlightNumber();
                                            SideFunctions.clearScreen();
                                        }
                                    }
                                    else if (value == "4")
                                    {
                                        Headers.header();
                                        SideFunctions.getHelp();
                                        SideFunctions.clearScreen();
                                    }
                                    else if (value == "5")
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }
                            }
                            else
                            {
                                CredentialsUI.inValidUser();
                                SideFunctions.clearScreen();
                            }
                        }
                        else if (input == "2")
                        {
                            Headers.header();
                            CredentialsBL user = CredentialsUI.takeInput();
                            bool test = CredentialsDL.checkUser(user);
                            if (test == true)
                            {
                                CredentialsUI.alreadyExists();
                                SideFunctions.clearScreen();
                            }
                            else
                            {
                                CredentialsDL.addUser(user);
                                CredentialsUI.signedUp();
                                SideFunctions.clearScreen();
                            }
                        }
                        else if(input == "3")
                        {
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }

                else if (option == "3")
                {
                    break;
                }

                else
                {
                    continue;
                }
            }
            Headers.header();
            SideFunctions.exit();
            SideFunctions.clearScreen();
        }
    }
}

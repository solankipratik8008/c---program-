namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {


            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Student Name:Pratikkumar Arvindbhai Solanki");
            Console.WriteLine("Student Number:9043621");
            Console.WriteLine("Student E-mail :Psolanki3621@conestogac.on.ca");


            Console.ResetColor();

            Console.WriteLine("enter any product that you want to buy \"Choices are\"  \n\"Apples\",\n\"Bananas\",\n\"Chillies\",\n\"Tomatoes\",\n\"Milk\"and\n\"Bread\"!");

            string newProductName = "";
            double discountForchilli = 0;
            double totalBill = 0;
            double appleWeight = 0;
            bool runTill = true;
            double bananaWeight = 0;
            String boughtAlready = "";
            double finalAppleWeight = 0;
            double finalBananaWeight = 0;
            double discountForapp = 0;
            double tomatoWeight = 0;
            double chilliWeight = 0;
            double milkCarton = 0;
            //double Bill = 0;
            double discountForban = 0;
            double breadLoaf = 0;
            double finaltomatoWeight = 0;
            double finalChilliWeight = 0;
            double finalBreadLoaf = 0;
            double finalMilkCarton = 0;
            String loyalityCard;

            double totalBillWithtax = 0;
            double bagUsed = 0.5;
            double totalBillNodis = 0;
            double Tax2 = 0;
            String bag;


            double taxRate = 0.13;
            string productName;
            double discountFortom = 0;
            string newProductName1 = newProductName;
            bool runtill2 = true;
            double totalBillWithtax2;
            //Console.WriteLine("do you have loyality card?");
            double Tax = 0;

            //productName = productName.Replace(" ", "");


            //Console.WriteLine("your total bill  now is........." + totalBill);


            // Console.WriteLine("enter any product from mentioned above or you may take \"done\" for your total bill with tax you bill without tax is " + totalBill);
            //productName = Console.ReadLine().Trim().ToLower();



            //newProductName = boughtAlready.Split(',').LastOrDefault()?.Trim();
            // newProductName = productName;

            //Console.WriteLine(runTill = false);

            while (true)
            {
                Console.WriteLine("Do you have any \" loyality card ?\" type YES OR NO Or type EXIT to terminate");
                //loyalityCard =Console.ReadLine().Trim().ToLower();
                loyalityCard = (Console.ReadLine() ?? "").Trim().ToLower();
                if (loyalityCard.ToLower() == "yes")
                {
                    Tax = (double)(totalBill * taxRate);
                    //Console.WriteLine("tax is " + Tax);
                    totalBillWithtax = (double)(totalBill + Tax);
                    //Console.WriteLine("your total bill till now with discount and tax is " + (totalBillWithtax) + "$");


                    Tax2 = (double)(totalBillNodis * taxRate);
                    //Console.WriteLine("Tax with  no any discount is " + Tax2);
                    totalBillWithtax2 = (double)(totalBillNodis + Tax2);

                    //Console.WriteLine("your total bill without tax is "+totalBill);


                    //newProductName = newProductName1;

                    Console.WriteLine("wow!you are eligible for 10% of discount");
                    //newProductName1 = newProductName;

                    // (productName == "apple" || productName == "apples")
                    while (runTill)
                    {


                        Console.WriteLine("Enter what you would like to buy " + "OR you may press \"done \" to see your bill Or type EXIT to terminate");
                        productName = (Console.ReadLine() ?? "").Trim().ToLower();


                        //Console.WriteLine(boughtAlready);




                        if (boughtAlready.ToLower().Contains(productName))
                        {


                            Console.WriteLine("you already bought that product! sorry you cannot buy it again Or you havenot entered yet!");


                            continue;
                        }



                        if (productName == "apples" || productName == "apple")
                        {






                            Console.WriteLine("enter how much apple do you want  buy in \"pound\" ");
                            appleWeight = Convert.ToDouble(Console.ReadLine());

                            if (appleWeight > 0)
                            {

                                Console.WriteLine("Your bill for Apple is " + appleWeight * 3 + "$");
                                boughtAlready += productName + ",";
                                finalAppleWeight = appleWeight * 3;
                                discountForapp = (double)(finalAppleWeight * 0.10);
                                double Bill1 = finalAppleWeight - discountForapp;
                                totalBill += Bill1;
                                totalBillNodis += finalAppleWeight;
                                Console.WriteLine("your biil with discount is " + totalBill);


                            }
                            else
                            {

                                Console.WriteLine(" You have entered ZERO or something else");
                            }

                        }


                        else if (productName == "bananas" || productName == "banana")
                        {





                            Console.WriteLine("enter how much bananas do you want  buy in \"pound\" ");
                            bananaWeight = Convert.ToDouble(Console.ReadLine());

                            if (bananaWeight > 0)
                            {

                                Console.WriteLine("Your bill for banaanas is " + bananaWeight * 4 + "$");
                                boughtAlready += productName + ",";
                                finalBananaWeight = bananaWeight * 4;
                                discountForban = (double)(finalBananaWeight * 0.10);
                                double Bill2 = (double)(finalBananaWeight - discountForban);
                                totalBill += Bill2;
                                totalBillNodis += finalBananaWeight;
                                Console.WriteLine("your biil with discount is " + totalBill);
                            }
                            else
                            {

                                Console.WriteLine(" You have entered ZERO or something else");
                            }

                        }

                        else if (productName == "tomatoes" || productName == "tomato")
                        {





                            Console.WriteLine("enter how much Tomato(es) do you want  buy in \"pound\" ");
                            tomatoWeight = Convert.ToDouble(Console.ReadLine());

                            if (tomatoWeight > 0)
                            {


                                Console.WriteLine("Your bill for tomatoes is " + tomatoWeight * 2 + "$");
                                boughtAlready += productName + ",";
                                finaltomatoWeight = tomatoWeight * 2;
                                discountFortom = (double)(finaltomatoWeight * 0.10);
                                double Bill3 = finaltomatoWeight - discountFortom;
                                totalBill += Bill3;
                                totalBillNodis += finaltomatoWeight;
                                Console.WriteLine("your biil with discount is " + totalBill);
                            }
                            else
                            {

                                Console.WriteLine(" You have entered ZERO or something else");
                            }

                        }


                        else if (productName == "chillies" || productName == "chilli")
                        {





                            Console.WriteLine("enter how much chilli(es) do you want  buy in \"pound\" ");
                            chilliWeight = Convert.ToDouble(Console.ReadLine());

                            if (chilliWeight > 0)
                            {

                                Console.WriteLine("Your bill for tomatoes is " + chilliWeight * 2 + "$");
                                boughtAlready += productName + ",";
                                finalChilliWeight = chilliWeight * 2;
                                discountForchilli = (double)(finalChilliWeight * 0.10);
                                double Bill4 = finalChilliWeight - discountForchilli;
                                totalBill += Bill4;
                                totalBillNodis = +finalChilliWeight;
                                Console.WriteLine("your biil with discount is " + totalBill);
                            }
                            else
                            {

                                Console.WriteLine(" You have entered ZERO or something else");
                            }

                        }



                        else if (productName == "milk")
                        {





                            Console.WriteLine("enter how many carton do you want  buy ? ");
                            milkCarton = Convert.ToDouble(Console.ReadLine());

                            if (milkCarton > 0)
                            {

                                Console.WriteLine("Your bill for milk is " + milkCarton * 5 + "$");
                                boughtAlready += productName + ",";
                                finalMilkCarton = milkCarton * 5;
                                totalBill += finalMilkCarton;
                                totalBillNodis += finalMilkCarton;
                                Console.WriteLine("your biil with dicount is " + totalBill + "\nyou may buy more products please ");
                            }
                            else
                            {

                                Console.WriteLine(" You have entered ZERO or something else");
                            }

                        }


                        else if (productName == "bread")
                        {





                            Console.WriteLine("enter how many loaf do you want  buy ? ");
                            breadLoaf = Convert.ToDouble(Console.ReadLine());

                            if (breadLoaf > 0)
                            {

                                Console.WriteLine("Your bill for bread  is " + breadLoaf * 6 + "$");
                                boughtAlready += productName + ",";
                                finalBreadLoaf = breadLoaf * 6;
                                totalBill += finalBreadLoaf;
                                totalBillNodis += finalBreadLoaf;
                                Console.WriteLine("your biil with discount is " + totalBill + "\nyou may buy more products please ");
                            }
                            else
                            {

                                Console.WriteLine(" You have entered ZERO or something else");
                            }

                        }



                        else if (string.IsNullOrEmpty(productName))
                        {
                            Console.WriteLine("nothing entered anything !.");


                        }










                        else
                        {

                            Console.WriteLine("you entered something else!!");



                        }


                        if (productName.ToLower() == "done")
                        {

                            Console.WriteLine("-------------------------------");
                            if (boughtAlready.Contains("apple"))
                            {
                                Console.WriteLine("Item:- Apple");
                                Console.WriteLine("Quantity of apple :" + appleWeight);
                                Console.WriteLine("discount for apple is " + discountForapp + "$");
                                Console.WriteLine("Base price for apple : 3$");
                                Console.WriteLine("apple cost is" + (double)(finalAppleWeight - discountForapp) + "$");
                            }

                            Console.WriteLine("-------------------------------");
                            if (boughtAlready.Contains("banana"))
                            {
                                Console.WriteLine("Item:- Banana");
                                Console.WriteLine("Quantity of banana :" + bananaWeight);
                                Console.WriteLine("discount for banana is " + discountForapp + "$");
                                Console.WriteLine("Base price for banana :4$");
                                Console.WriteLine("banana cost is" + (double)(finalBananaWeight - discountForban) + "$");




                            }
                            Console.WriteLine("-------------------------------");
                            if (boughtAlready.Contains("chilli"))
                            {
                                Console.WriteLine("Item:- chilli");
                                Console.WriteLine("Quantity of chilli :" + chilliWeight);
                                Console.WriteLine("discount for chilli is " + discountForchilli + "$");
                                Console.WriteLine("Base price for chilli :1$");
                                Console.WriteLine("chilli cost is" + (double)(finalChilliWeight - discountForchilli) + "$");




                            }
                            Console.WriteLine("-------------------------------");
                            if (boughtAlready.Contains("tomato"))
                            {
                                Console.WriteLine("Item:- tomato");
                                Console.WriteLine("Quantity of tomato:" + tomatoWeight);
                                Console.WriteLine("discount for tomato is " + discountFortom + "$");
                                Console.WriteLine("Base price for tomato :2$");
                                Console.WriteLine("tomato cost is" + (double)(finaltomatoWeight - discountFortom) + "$");




                            }
                            Console.WriteLine("-------------------------------");
                            if (boughtAlready.Contains("milk"))
                            {
                                Console.WriteLine("Item:- milk");
                                Console.WriteLine("Quantity of milk :" + milkCarton);
                                Console.WriteLine("discount for milk is " + 0 + "$");
                                Console.WriteLine("Base price for milk : 5$");
                                Console.WriteLine("milk cost is" + finalMilkCarton + "$");




                            }
                            if (boughtAlready.Contains("bread"))
                            {
                                Console.WriteLine("Item:- bread");
                                Console.WriteLine("Quantity of bread :" + breadLoaf);
                                Console.WriteLine("discount for bread is " + 0 + "$");
                                Console.WriteLine("Base price for bread : 4$");
                                Console.WriteLine("bread cost is" + finalBreadLoaf + "$");




                            }
                            Console.WriteLine("-------------------------------");

                            Tax = (double)(totalBill * taxRate);
                            //Console.WriteLine("tax is " + Tax);
                            totalBillWithtax = (double)(totalBill + Tax);


                            Console.WriteLine("do you want to buy bag(s)?");
                            bag = (Console.ReadLine() ?? "");
                            //double bill = (double)totalBill;

                            if (bag.ToLower() == "yes")
                            {
                                Console.WriteLine("how many bags have you bought?");

                                double bagsNumber = (Convert.ToDouble(Console.ReadLine()));
                                bagUsed = bagsNumber * 0.5;

                                double newtotalBillWithtax = bagUsed + totalBillWithtax;
                                Tax = (double)(totalBill * taxRate);
                                //Console.WriteLine("tax is " + Tax);
                                totalBillWithtax = (double)(totalBill + Tax);

                                Console.WriteLine("-----------------------");
                                Console.WriteLine("subtotal with discount " + totalBill + "$");
                                Console.WriteLine("cost of bag(s):0.5$");
                                Console.WriteLine("Total cost of bag is " + bagUsed + "$");

                                Console.WriteLine("Tax is :" + Tax);

                                Console.WriteLine("grand total is : " + newtotalBillWithtax);





                                // Console.WriteLine("you  can get discount of \"10%\" discount is not applied in \"MILK and BREAD\"");

                                // Console.WriteLine("Your total bill with discount is " + totalBillWithtax);

                                // Tax2 = (double)(totalBillNodis * taxRate);
                                //Console.WriteLine("Tax with  no any discount is " + Tax2);
                                // totalBillNodis = (double)(totalBillNodis + Tax2);



                            }



                            else if (bag.ToLower() == "no")
                            {

                                Console.WriteLine("-----------------------");

                                Console.WriteLine("subtotal with discount:-" + totalBill + "$");
                                Console.WriteLine("cost of bag(s):0.5$");
                                Console.WriteLine("Total cost of bag is 0$");

                                Console.WriteLine("Tax is :" + Tax);

                                // Console.WriteLine("your total bill till now with discount and tax is " + (totalBillWithtax) + "$");
                                Console.WriteLine("your final bill wiht tax and \"no\" bags is " + (totalBillWithtax) + "$");
                                Console.WriteLine("have a nice one! bye !");




                            }

                            else
                            {

                                Console.WriteLine("you have entered something else!!");
                                continue;
                            }

                        }



                        if (productName == "exit")
                        {

                            Environment.Exit(0);
                            //break;
                            //runTill = false;
                        }



                    }
                    Console.WriteLine("come again!bye");

                }




                if (loyalityCard.ToLower() == "no")


                {


                    Tax2 = (double)(totalBillNodis * taxRate);
                    //Console.WriteLine("Tax with  no any discount is " + Tax2);
                    totalBillWithtax2 = (double)(totalBillNodis + Tax2);
                    Console.WriteLine("sorry! you are not eligible for 10% of discounnt");
                    //Console.WriteLine("Do you want to buy bag?");

                    runtill2 = true;
                    while (runtill2)
                    {


                        Console.WriteLine("Enter what you would like to buy OR you may press \"done \" to see your bill OR just press EXIT to close window ");
                        productName = (Console.ReadLine() ?? "").Trim().ToLower();


                        //Console.WriteLine(boughtAlready);



                        if (boughtAlready.ToLower().Contains(productName))
                        {


                            Console.WriteLine("you already bought that product! sorry you cannot buy it again");


                            continue;
                        }



                        Tax2 = (double)(totalBillNodis * taxRate);
                        //Console.WriteLine("Tax with  no any discount is " + Tax2);
                        totalBillWithtax2 = (double)(totalBillNodis + Tax2);
                        // Console.WriteLine("sorry! you are not eligible for 10% of discounnt");
                        //Console.WriteLine("Do you want to buy bag?");






                        if (productName == "apples" || productName == "apple")
                        {






                            Console.WriteLine("enter how much apple do you want  buy in \"pound\" ");
                            appleWeight = Convert.ToDouble(Console.ReadLine());

                            if (appleWeight > 0)
                            {

                                Console.WriteLine("Your bill for Apple is " + appleWeight * 3 + "$");
                                boughtAlready += productName + ",";
                                finalAppleWeight = appleWeight * 3;
                                discountForapp = (double)(finalAppleWeight * 0.10);
                                double Bill1 = finalAppleWeight - discountForapp;
                                totalBill += Bill1;
                                totalBillNodis += finalAppleWeight;
                                // Console.WriteLine("your total bill till now is" + totalBill);


                            }
                            else
                            {

                                Console.WriteLine(" You have entered ZERO or something else");
                            }

                        }


                        else if (productName == "bananas" || productName == "banana")
                        {





                            Console.WriteLine("enter how much bananas do you want  buy in \"pound\" ");
                            bananaWeight = Convert.ToDouble(Console.ReadLine());

                            if (bananaWeight > 0)
                            {

                                Console.WriteLine("Your bill for banaanas is " + bananaWeight * 4 + "$");
                                boughtAlready += productName + ",";
                                finalBananaWeight = bananaWeight * 4;
                                discountForban = (double)(finalBananaWeight * 0.10);
                                double Bill2 = (double)(finalBananaWeight - discountForban);
                                totalBill += Bill2;
                                totalBillNodis += finalBananaWeight;
                                // Console.WriteLine("your total bill till now is" + totalBill);
                            }
                            else
                            {

                                Console.WriteLine(" You have entered ZERO or something else");
                            }

                        }

                        else if (productName == "tomatoes" || productName == "tomato")
                        {





                            Console.WriteLine("enter how much Tomato(es) do you want  buy in \"pound\" ");
                            tomatoWeight = Convert.ToDouble(Console.ReadLine());

                            if (tomatoWeight > 0)
                            {


                                Console.WriteLine("Your bill for tomatoes is " + tomatoWeight * 2 + "$");
                                boughtAlready += productName + ",";
                                finaltomatoWeight = tomatoWeight * 2;
                                discountFortom = (double)(finaltomatoWeight * 0.10);
                                double Bill3 = finaltomatoWeight - discountFortom;
                                totalBill += Bill3;
                                totalBillNodis += finaltomatoWeight;
                                //Console.WriteLine("your total bill till now is" + totalBill);
                            }
                            else
                            {

                                Console.WriteLine(" You have entered ZERO or something else");
                            }

                        }


                        else if (productName == "chillies" || productName == "chilli")
                        {





                            Console.WriteLine("enter how much chilli(es) do you want  buy in \"pound\" ");
                            chilliWeight = Convert.ToDouble(Console.ReadLine());

                            if (chilliWeight > 0)
                            {

                                Console.WriteLine("Your bill for tomatoes is " + chilliWeight * 2 + "$");
                                boughtAlready += productName + ",";
                                finalChilliWeight = chilliWeight * 2;
                                discountForchilli = (double)(finalChilliWeight * 0.10);
                                double Bill4 = finalChilliWeight - discountForchilli;
                                totalBill += Bill4;
                                totalBillNodis = +finalChilliWeight;
                                //Console.WriteLine("your total bill till now is" + totalBill);
                            }
                            else
                            {

                                Console.WriteLine(" You have entered ZERO or something else");
                            }

                        }



                        else if (productName == "milk")
                        {





                            Console.WriteLine("enter how many carton do you want  buy ? ");
                            milkCarton = Convert.ToDouble(Console.ReadLine());

                            if (milkCarton > 0)
                            {

                                Console.WriteLine("Your bill for milk is " + milkCarton * 5 + "$");
                                boughtAlready += productName + ",";
                                finalMilkCarton = milkCarton * 5;
                                totalBill += finalMilkCarton;
                                totalBillNodis += finalMilkCarton;
                                // Console.WriteLine("your total bill till now is" + totalBill + "\nyou may buy more products please ");
                            }
                            else
                            {

                                Console.WriteLine(" You have entered ZERO or something else");
                            }

                        }


                        else if (productName == "bread")
                        {





                            Console.WriteLine("enter how many loaf do you want  buy ? ");
                            breadLoaf = Convert.ToDouble(Console.ReadLine());

                            if (breadLoaf > 0)
                            {

                                Console.WriteLine("Your bill for bread  is " + breadLoaf * 6 + "$");
                                boughtAlready += productName + ",";
                                finalBreadLoaf = breadLoaf * 6;
                                totalBill += finalBreadLoaf;
                                totalBillNodis += finalBreadLoaf;
                                //Console.WriteLine("your total bill till now is" + totalBill + "\nyou may buy more products please ");
                            }
                            else
                            {

                                Console.WriteLine(" You have entered ZERO or something else");

                                continue;
                            }

                        }



                        else if (string.IsNullOrEmpty(productName))
                        {
                            Console.WriteLine("not correct input try again !.");

                        }



                        else
                        {

                            Console.WriteLine("you have entered something esle !!");
                        }









                        Tax2 = (double)(totalBillNodis * taxRate);
                        //Console.WriteLine("Tax with  no any discount is " + Tax2);
                        totalBillWithtax2 = (double)(totalBillNodis + Tax2);
                        //Console.WriteLine("sorry! you are not eligible for 10% of discounnt");
                        // Console.WriteLine("Do you want to buy bag?");



                        if (productName.ToLower() == "done")
                        {


                            Console.WriteLine("-------------------------------");
                            if (boughtAlready.Contains("apple"))
                            {
                                Console.WriteLine("Item:- Apple");
                                Console.WriteLine("Quantity of apple :" + appleWeight);
                                Console.WriteLine("discount for apple is " + 0 + "$");
                                Console.WriteLine("Base price for apple :3$");
                                Console.WriteLine("apple cost is" + finalAppleWeight + "$");
                            }

                            Console.WriteLine("-------------------------------");


                            if (boughtAlready.Contains("banana"))
                            {
                                Console.WriteLine("Item:- Banana");
                                Console.WriteLine("Quantity of banana :" + bananaWeight);
                                Console.WriteLine("discount for banana is " + 0 + "$");
                                Console.WriteLine("Base price for banana : 4$");
                                Console.WriteLine("banana cost is" + finalBananaWeight + "$");




                            }

                            Console.WriteLine("-------------------------------");
                            if (boughtAlready.Contains("chilli"))
                            {
                                Console.WriteLine("Item:- chilli");
                                Console.WriteLine("Quantity of chilli :" + chilliWeight);
                                Console.WriteLine("discount for chilli is " + 0 + "$");
                                Console.WriteLine("Base price for chilli : 1$");
                                Console.WriteLine("chilli cost is" + finalChilliWeight + "$");




                            }
                            Console.WriteLine("-------------------------------");
                            if (boughtAlready.Contains("tamato"))
                            {
                                Console.WriteLine("Item:- tomato");
                                Console.WriteLine("Quantity of tomato:" + tomatoWeight);
                                Console.WriteLine("discount for tomato is " + 0 + "$");
                                Console.WriteLine("Base price for tomato : 2$");
                                Console.WriteLine("tomato cost is" + finaltomatoWeight + "$");




                            }
                            Console.WriteLine("-------------------------------");
                            if (boughtAlready.Contains("milk"))
                            {
                                Console.WriteLine("Item:- milk");
                                Console.WriteLine("Quantity of milk :" + milkCarton);
                                Console.WriteLine("discount for milk is " + 0 + "$");
                                Console.WriteLine("Base price for banana : 5$");
                                Console.WriteLine("milk cost is" + finalMilkCarton + "$");




                            }
                            Console.WriteLine("-------------------------------");

                            if (boughtAlready.Contains("bread"))
                            {
                                Console.WriteLine("Item:- bread");
                                Console.WriteLine("Quantity of bread :" + breadLoaf);
                                Console.WriteLine("discount for bread is " + 0 + "$");
                                Console.WriteLine("Base price for bread : 6$");
                                Console.WriteLine("bread cost is" + finalBreadLoaf + "$");




                            }
                            Console.WriteLine("-------------------------------");

                            Tax2 = (double)(totalBillNodis * taxRate);
                            //Console.WriteLine("Tax with  no any discount is " + Tax2);
                            totalBillWithtax2 = (double)(totalBillNodis + Tax2);
                            // Console.WriteLine("sorry! you are not eligible for 10% of discounnt");
                            Console.WriteLine("Do you want to buy bag?");
                            bag = (Console.ReadLine() ?? "");
                            double bill3 = totalBillWithtax2;

                            if (bag.ToLower() == "yes")
                            {


                                //Console.WriteLine("sorry!,you are not eligible for 10% of discount ");
                                //Console.WriteLine("your bill without any discount is " + totalBillWithtax2 + "$");
                                // Console.WriteLine("your total bill till now without any discount and tax is " + totalBillWithtax + "$");
                                //Console.WriteLine(" Do you want to use bag?");

                                Console.WriteLine("how many bags have you bought?");

                                double bagsNumber = (Convert.ToDouble(Console.ReadLine()));
                                bagUsed = bagsNumber * 0.5;
                                bill3 = totalBillWithtax2;
                                Console.WriteLine("-------------------------------");
                                Console.WriteLine("tax is " + Tax2);
                                Console.WriteLine("subtotal with =out tax is  " + totalBillNodis + "$");
                                Console.WriteLine("your total bill with tax is " + totalBillWithtax2 + "$");


                                bill3 = bagUsed + bill3;
                                Console.WriteLine("So your total bill with bag(s) is " + bill3);
                                Console.WriteLine("have a nice one! bye !");
                                break;


                            }
                            else if (bag.ToLower() == "no")
                            {

                                //Console.WriteLine("then your bill is "+totalBillWithtax);
                                Console.WriteLine("-------------------------------");
                                //Console.WriteLine("sorry! you care not eligible for discount");
                                Console.WriteLine("subtotal with =out tax is  " + totalBillNodis + "$");

                                Console.WriteLine("your final bill wiht tax is and with  \" no bags\" " + totalBillWithtax2 + "$");
                                Console.WriteLine("tax is " + Tax2);

                                Console.WriteLine("have a nice one! bye !");


                                Console.WriteLine(runtill2 = false);


                                break;


                            }




                            else
                            {

                                Console.WriteLine("you have entered something else!!");

                            }

                        }
                        string productName1 = productName;
                        if (productName1 == "exit")
                        {
                            Environment.Exit(0);
                            //break;
                            // runtill2 = false;
                        }
                    }

                    Console.WriteLine("thank you! for shopping!");

                }


                else if (string.IsNullOrEmpty(loyalityCard))
                {
                    Console.WriteLine("You have to enter something!");

                }


                else if (loyalityCard == "exit")
                {

                    Environment.Exit(0);
                    //break;
                    //runTill = false;
                }

                else
                {

                    Console.WriteLine("you have entered something else ");
                    continue;
                }



            }




        }
    }

}

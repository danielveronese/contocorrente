using System;

namespace contocorrente
{
    class Contocorrente
    {
        public double saldo, importo;

        public double Versamento()
        {
            

            saldo = saldo + importo;

            return saldo;
        }
        public double Prelievo()
        {


            saldo = saldo - importo;

            return saldo;
        }
        public double Setsaldo()
        {
            saldo = Convert.ToDouble(Console.ReadLine());

            return saldo;
        }



    }
    class Contontolimitato : Contocorrente
    {



    }
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, s, n, g;
            g = 0; i = 0; j = 0; s = 0; n = 0;
            Contocorrente c = new Contocorrente();
            Contontolimitato cl = new Contontolimitato();



            for (i = 0; i == 0; i++)
            {
                Console.WriteLine("se vuoi creare un nuovo conto premi 1");
                Console.WriteLine("se vuoi creare un nuovo conto con limite di trasferimento premi 2");
                Console.WriteLine("se vuoi uscire dal programma premi 3");
                s = Convert.ToInt32(Console.ReadLine());
                if (s == 1)
                {
                    if (c.saldo == 0)
                    {
                        Console.WriteLine("qunti soldi hai nel conto");
                        c.Setsaldo();
                    }

                    for (j = 0; j == 0; j++)
                    {

                        Console.WriteLine("il tuo acconto è di {0} euro", c.saldo);
                        Console.WriteLine("se vuoi vuoi prelevare premi 1");
                        Console.WriteLine("se vuoi fare un versamento premi  2");
                        Console.WriteLine("se vuoi vuoi tornare al menù principale premi 3");

                        n = Convert.ToInt32(Console.ReadLine());
                        if (n == 1)
                        {
                            Console.WriteLine("quanti soldi vuoi prelevare?");
                            c.importo = Convert.ToDouble(Console.ReadLine());

                            if (c.importo > c.saldo)
                            {
                                Console.WriteLine("non hai abbastanza soldi nel conto per prelevare quella cifra prova a fare un versamento o preleva una cifra più bassa ");
                                j--;


                            }
                            else
                            {
                                
                                c.Prelievo();
                                j--;
                            }



                        }
                        else
                        {
                            if (n == 2)
                            {
                                Console.WriteLine("qunti soldi vuoi depositare?");
                                c.importo = Convert.ToDouble(Console.ReadLine());
                                c.Versamento();
                                j--;



                            }
                            else
                            {


                            }

                            if (n == 3)
                            {

                                i--;


                            }
                            else
                            {

                                Console.WriteLine("non ho capito la tua scelta perfavore inserisci i numeri 1-2-3");
                                j--;

                            }


                        }

                    }






                }






                else
                {
                    if (s == 2)
                    {
                        if (cl.saldo == 0)
                        {
                            Console.WriteLine("qunti soldi hai nel conto");
                            cl.Setsaldo();
                        }

                        for (j = 0; j == 0; j++)
                        {

                            Console.WriteLine("il tuo acconto è di {0} euro", cl.saldo);
                            Console.WriteLine("se vuoi vuoi prelevare con il limite di trasferimento di 3000 euro premi 1");
                            Console.WriteLine("se vuoi fare un versamento premi 2");
                            Console.WriteLine("se vuoi vuoi tornare al menù principale premi 3");
                            g = Convert.ToInt32(Console.ReadLine());



                            if (g == 1)
                            {
                                Console.WriteLine("quanti soldi vuoi prelevare?");
                                cl.importo = Convert.ToDouble(Console.ReadLine());

                                if (cl.importo > cl.saldo)
                                {
                                    Console.WriteLine("non hai abbastanza soldi nel conto per prelevare quella cifra prova a fare un versamento o preleva una cifra più bassa ");

                                    j--;

                                }
                                else
                                {
                                    if (cl.importo >= 3000)
                                    {
                                        Console.WriteLine("non puoi prelevare un importo superiore ai 3000 euro");
                                        j--;


                                    }
                                    else
                                    {

                                        cl.Prelievo();
                                        j--;


                                    }
                                }

                            }
                            else
                            {
                                if (g == 2)
                                {
                                    Console.WriteLine("qunti soldi vuoi depositare?");
                                    cl.importo = Convert.ToDouble(Console.ReadLine());
                                    cl.Versamento();
                                    j--;




                                }
                                else
                                {
                                    if(g == 3)
                                    {
                                        i--;

                                    }
                                    else
                                    {

                                        Console.WriteLine("non ho capito la tua scelta perfavore inserisci i numeri 1-2-3");
                                        j--;

                                    }


                                }


                            }
                        }
                    }
                    else
                    {
                        if (s == 3)
                        {

                        }
                        else
                        {
                            Console.WriteLine("non ho capito la tua risposta per favore inserisci solo 1,2,3");
                            i--;

                        }



                    }

                    }


                }



            }
        }
    }

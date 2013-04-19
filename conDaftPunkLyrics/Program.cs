using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.pixelsyndicate.daftpunklyrics
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" - Daft Punk Lyrics - ");
            WorkIt();
            Console.WriteLine("Press ENTER to close this");

            // this closes the console when submitting anything (ENTER key)
            if (Console.Read() != null) {}

        }

        private static void WorkIt()
        {
            // Converted from JavaScript to C# by Wil Dobson (wdobson@pixelsyndicate.com)
            //  So that even Microsoft/Mono servers can understand 
            // Daft Punk's song 'Harder, Better, Faster, Stronger',
            // Original JavaScript programmer unknown

            Nullable<int> j, k, i;

            for (k = 0; k < 16; k++)
            {
                for (j = 0; j < 4; j++)
                {
                    for (i = 0; i < 4; i++)
                    {
                        switch (i)
                        {
                            case 0:
                                switch (j)
                                {
                                    case 0:
                                        switch (k)
                                        {
                                            case 0:
                                                Console.WriteLine("Work it ");
                                                break;
                                            case 1:
                                                Console.WriteLine("Work it ");
                                                break;
                                            default:
                                                Console.WriteLine("Work it Harder ");
                                                break;
                                        }
                                        break;
                                    case 1:
                                        switch (k)
                                        {
                                            case 0:
                                                Console.WriteLine("Harder ");
                                                break;
                                            case 1:
                                                Console.WriteLine("Harder ");
                                                break;
                                        }
                                        break;
                                    case 2:
                                        switch (k)
                                        {
                                            case 0:
                                                Console.WriteLine("More than ");
                                                break;
                                            case 1:
                                                break;
                                            default:
                                                Console.WriteLine("More than ever ");
                                                break;
                                        }
                                        break;
                                    case 3:
                                        if (k == 0)
                                        {
                                            Console.WriteLine("Ever ");
                                        }
                                        else
                                        {
                                            Console.WriteLine("");
                                        }
                                        break;
                                }
                                break;
                            case 1:
                                switch (j)
                                {
                                    case 0:
                                        switch (k)
                                        {
                                            case 0:
                                                Console.WriteLine("Make it ");
                                                break;
                                            case 1:
                                                Console.WriteLine("Make it ");
                                                break;
                                            case 14:
                                                break;
                                            default:
                                                Console.WriteLine("Make it Better ");
                                                break;
                                        }
                                        break;
                                    case 1:
                                        switch (k)
                                        {
                                            case 0:
                                                Console.WriteLine("Better ");
                                                break;
                                            case 1:
                                                Console.WriteLine("Better ");
                                                break;
                                        }
                                        break;
                                    case 2:
                                        switch (k)
                                        {
                                            case 0:
                                                Console.WriteLine("Hour ");
                                                break;
                                            case 1:
                                                break;
                                            case 14:
                                                break;
                                            default:
                                                Console.WriteLine("Hour After ");
                                                break;
                                        }
                                        break;
                                    case 3:
                                        if (k == 0)
                                        {
                                            Console.WriteLine("After ");
                                        }
                                        else
                                        {
                                            Console.WriteLine("");
                                        }
                                        //print (k==0) ? "After " : "";
                                        break;
                                }
                                break;
                            case 2:
                                switch (j)
                                {
                                    case 0:
                                        switch (k)
                                        {
                                            case 0:
                                                Console.WriteLine("Do it ");
                                                break;
                                            case 1:
                                                Console.WriteLine("Do it ");
                                                break;
                                            default:
                                                Console.WriteLine("Do it Faster ");
                                                break;
                                        }
                                        break;
                                    case 1:
                                        switch (k)
                                        {
                                            case 0:
                                                Console.WriteLine("Faster ");
                                                break;
                                            case 1:
                                                Console.WriteLine("Faster ");
                                                break;
                                        }
                                        break;
                                    case 2:
                                        switch (k)
                                        {
                                            case 0:
                                                Console.WriteLine("Our ");
                                                break;
                                            case 1:
                                                break;
                                            default:
                                                Console.WriteLine("Our Work Is ");
                                                break;
                                        }
                                        break;
                                    case 3:
                                        if (k == 0)
                                        {
                                            Console.WriteLine("Work is ");
                                        }
                                        else
                                        {
                                            Console.WriteLine("");
                                        }
                                        break;
                                }
                                break;
                            case 3:
                                switch (j)
                                {
                                    case 0:
                                        switch (k)
                                        {
                                            case 0:
                                                Console.WriteLine("Makes Us ");
                                                break;
                                            case 1:
                                                Console.WriteLine("Makes Us ");
                                                break;
                                            case 14:
                                                break;
                                            default:
                                                Console.WriteLine("Makes us Stronger ");
                                                break;
                                        }
                                        break;
                                    case 1:
                                        switch (k)
                                        {
                                            case 0:
                                                Console.WriteLine("Stronger ");
                                                break;
                                            case 1:
                                                Console.WriteLine("Stronger ");
                                                break;
                                        }
                                        break;
                                    case 2:
                                        switch (k)
                                        {
                                            case 0:
                                                Console.WriteLine("Never ");
                                                break;
                                            case 1:
                                                break;
                                            default:
                                                Console.WriteLine("Never Over ");
                                                break;
                                        }
                                        break;
                                    case 3:
                                        if (k == 0)
                                        {
                                            Console.WriteLine("Over ");
                                        }
                                        else
                                        {
                                            Console.WriteLine("");
                                        }
                                        break;
                                }
                                break;
                        }
                    }
                }
            }

        }
    }
}

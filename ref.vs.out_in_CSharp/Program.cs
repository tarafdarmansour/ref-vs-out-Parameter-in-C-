using System;

namespace refvsout_in_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int myvar_ref1  ;
            int myvar_ref2;
            myvar_ref1 = 10; //It's Mandatory
            myvar_ref2 = 20; //It's Mandatory

            // Console.WriteLine($"myvar_ref before passing to Changevalue_ref : {myvar_ref}");

            Changevalue_ref(ref myvar_ref1,ref myvar_ref2);

            Console.WriteLine($"myvar_ref1 after passing to Changevalue_ref : {myvar_ref1}");
            Console.WriteLine($"myvar_ref2 after passing to Changevalue_ref : {myvar_ref2}");

            int myvar_out1;
            int myvar_out2;
            //myvar_out1 = 10; //It's NOT Mandatory
            //myvar_out2 = 10; //It's NOT Mandatory

            //  Console.WriteLine($"myvar_out before passing to Changevalue_out : {myvar_out}");

            Changevalue_out(out myvar_out1,out myvar_out2);

            Console.WriteLine($"myvar_out after passing to Changevalue_out : {myvar_out1}");
            Console.WriteLine($"myvar_out after passing to Changevalue_out : {myvar_out2}");

        }

        private static bool Changevalue_ref(ref int value1,ref int value2)
        {
            try
            {
                //data passed  bidirectional

                value1 += 1;
                value2 += 2;
                return true;
            }
            catch (Exception)
            {
                return false;
            }


        }

        private static bool Changevalue_out(out int value1, out int value2)
        {
            //data passed  unidirectional
            value1 = 0; //It's Mandatory
            value2 = 0; //It's Mandatory
            try
            {
                value1 += 1;
                value2 += 2;
                return true; // you cannot return till set all out parameters
            }
            catch (Exception)
            {
                return false; // you cannot return till set all out parameters
            }


        }
    }

    
}

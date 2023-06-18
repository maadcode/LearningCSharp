namespace CSharpFundamentals.Basic
{
    public class Conditionals
    {
        public static void IfElseExample()
        {
            var age = 19;
            if(age >= 18)
            {
                Console.WriteLine("Adult");
            } else
            {
                Console.WriteLine("Younger");
            }

            if(age % 2 == 0)
            {
                Console.WriteLine("Is even");
            }

            if(age >= 0 && age <= 11)
            {
                Console.WriteLine("Infant");

            } else if(age >= 12 && age <= 18)
            {
                Console.WriteLine("Teen");
            } else if (age >= 19 && age <= 26)
            {
                Console.WriteLine("Young");
            } else if (age >= 27 && age <= 59)
            {
                Console.WriteLine("Adult");
            } else
            {
                Console.WriteLine("Old man");
            }
        }
        public static void SwitchExample()
        {
            var option = EnumArithmeticOperator.MULTIPLICATION;
            switch (option)
            {
                case EnumArithmeticOperator.ADDITION:
                    Console.WriteLine("option addition");
                    break;
                case EnumArithmeticOperator.SUBTRACTION:
                    Console.WriteLine("option subtraction");
                    break;
                case EnumArithmeticOperator.MULTIPLICATION:
                    Console.WriteLine("option multiplication");
                    break;
                case EnumArithmeticOperator.DIVISION:
                    Console.WriteLine("option division");
                    break;
                default: Console.WriteLine("option invalid");
                    break;
            }

            // Other use
            var numberOne = 10;
            var numberTwo = 12;
            var result = option switch
            {
                EnumArithmeticOperator.ADDITION => numberOne + numberTwo,
                EnumArithmeticOperator.SUBTRACTION => numberOne - numberTwo,
                EnumArithmeticOperator.MULTIPLICATION => numberOne * numberTwo,
                EnumArithmeticOperator.DIVISION => numberOne / numberTwo,
                _ => throw new NotImplementedException()
            };
            Console.WriteLine(result);
        }
        public static void TernaryOperatorExample()
        {
            var age = 21;
            //Without Ternary operator
            string response1 = string.Empty;
            if(age < 18)
            {
                response1 = "Younger";
            } else
            {
                response1 = "Adult";
            }
            Console.WriteLine(response1);

            // With Ternary operator
            string response2 = age < 18 ? "Younger" : "Adult";
            Console.WriteLine(response2);
        }
        public static void NullCoalescingOperatorExample()
        {
            // Without Null Coleascing operator
            string name = null;
            string response1 = string.Empty;
            if (name != null)
            {
                response1 = name;
            } else
            {
                response1 = "unknown";
            }
            Console.WriteLine("Without Null Coleascing Operator: " + response1);

            // With Null Coleascing operator
            string name2 = null;
            string response2 = name2 ?? "Unknown";
            Console.WriteLine("Without Null Coleascing Operator: " + response2);
        }

        public static void NullCoalescingAssignmentExample()
        {
            // Without Null Coleascing Assignment
            string name = null;
            string response1 = string.Empty;
            if (name != null)
            {
                response1 = name;
            } else
            {
                response1 = "Unknown";
                name = "Unknown";
            }
            Console.WriteLine("Without Null Coleascing Assignment: " + response1);
            Console.WriteLine("Without Null Coleascing Assignment: " + name);

            // With Null Coleascing Assignment
            string name2 = null;
            var response2 = name2 ??= "Unknown";
            Console.WriteLine("With Null Coleascing Assignment: " + response2);
            Console.WriteLine("With Null Coleascing Assignment: " + name2);
        }
    }
}
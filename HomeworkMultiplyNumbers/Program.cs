using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorldProject {
    class HomeworkMultiplyNumbers {
        
           
                public void Start() { 

            var product = 1;
            for(var number = 1; number <= 10; number++) {
                product = product * number;
                }

            Console.WriteLine($"Product of numbers 1 to 10 is {product}");

            }
        }
    }

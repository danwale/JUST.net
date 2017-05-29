﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JUST;
using System.IO;

namespace JUST.NET.Test
{
    class Program
    {
        public static void Main(string[] args)
        {
            string input = File.ReadAllText("Examples/Input.json");

            string transformer = File.ReadAllText("Examples/Transformer_valueof.json"); 
            string transformedString = JsonTransformer.Transform(transformer, input);
            Console.WriteLine("################################################################################################");
            Console.WriteLine(transformedString);


            transformer = File.ReadAllText("Examples/Transformer_valueofarray.json");
            transformedString = JsonTransformer.Transform(transformer, input);
            Console.WriteLine("################################################################################################");
            Console.WriteLine(transformedString);


            transformer = File.ReadAllText("Examples/Transformer_copy.json");
            transformedString = JsonTransformer.Transform(transformer, input);
            Console.WriteLine("################################################################################################");
            Console.WriteLine(transformedString);

            transformer = File.ReadAllText("Examples/Transformer_replace.json");
            transformedString = JsonTransformer.Transform(transformer, input);
            Console.WriteLine("################################################################################################");
            Console.WriteLine(transformedString);

            transformer = File.ReadAllText("Examples/Transformer_delete.json");
            transformedString = JsonTransformer.Transform(transformer, input);
            Console.WriteLine("################################################################################################");
            Console.WriteLine(transformedString);


            transformer = File.ReadAllText("Examples/Transformer_ifcondition.json");
            transformedString = JsonTransformer.Transform(transformer, input);
            Console.WriteLine("################################################################################################");
            Console.WriteLine(transformedString);

            transformer = File.ReadAllText("Examples/Transformer_string.json");
            transformedString = JsonTransformer.Transform(transformer, input);
            Console.WriteLine("################################################################################################");
            Console.WriteLine(transformedString);

            transformer = File.ReadAllText("Examples/Transformer_math.json");
            transformedString = JsonTransformer.Transform(transformer, input);
            Console.WriteLine("################################################################################################");
            Console.WriteLine(transformedString);

            transformer = File.ReadAllText("Examples/Transformer_aggregate.json");
            transformedString = JsonTransformer.Transform(transformer, input);
            Console.WriteLine("################################################################################################");
            Console.WriteLine(transformedString);

            transformer = File.ReadAllText("Examples/Transformer_arrayaggregate.json");
            transformedString = JsonTransformer.Transform(transformer, input);
            Console.WriteLine("################################################################################################");
            Console.WriteLine(transformedString);

            transformer = File.ReadAllText("Examples/Transformer_looping.json");
            transformedString = JsonTransformer.Transform(transformer, input);
            Console.WriteLine("################################################################################################");
            Console.WriteLine(transformedString);

            transformer = File.ReadAllText("Examples/Transformer_customfunction.json");
            transformedString = JsonTransformer.Transform(transformer, input);
            Console.WriteLine("################################################################################################");
            Console.WriteLine(transformedString);


            transformer = File.ReadAllText("Examples/Transformer.json");
            transformedString = JsonTransformer.Transform(transformer, input);
            Console.WriteLine("################################################################################################");
            Console.WriteLine(transformedString);

        }
    }
}
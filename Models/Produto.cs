using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MVCConsole.Models
{
    public class Produto
    {
        public int Code { get; set; }
        public string Name {get; set;}
        public float Cost {get; set;}
        private const string PATH = "Database/produto.csv";

         public string Separate(string data)
            {
                return data.Split("=")[1];
            }

        public List<Produto> Read()
        {
             //create the list for get the return 
            List<Produto> prod = new List<Produto>();


            //Read the .csv and add a array lines
            string[] lines = File.ReadAllLines(PATH);

            //sweep our lines 
            foreach(string line in lines )
            {
                //code=1;name=Keybord and Mouse;cost=579.8
                string[] data = line.Split(";"); 

                Produto p = new Produto();
                p.Code = Int32.Parse(Separate(data[0]));
                p.Name = Separate(data[1]);
                p.Cost = float.Parse( Separate(data[2]));

                
                prod.Add(p);
                //orderned names as alphabet
                prod = prod.OrderBy(z => z.Name).ToList();
                
            } return prod;
        }
    }
}
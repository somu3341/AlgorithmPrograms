﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms.CustomizeMessage
{
    public class CustomizeDeatils
    {
        public void Customize()
        {
            string line = "Hello <<name>>, We have your full name as <<full name>> in our system. your contact number is 91-xxxxxxxxx. Today's Date <<date>>.";
            line = line.Replace("<<name>>","Somu");
            line = line.Replace("<<full name>>","SomaShekar");
            line = line.Replace("91-xxxxxxxxx","91-987654321");
            line = line.Replace("<<date>>","25/03/2023");
            Console.WriteLine(line);
        }
        
    }
}

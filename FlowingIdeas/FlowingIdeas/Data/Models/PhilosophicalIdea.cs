using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowingIdeas.Data.Models
{
    internal class PhilosophicalIdea : Idea
    {
        private string textOfPhilIdea;

        public override string TextOfIdea 
        { 
            get 
            {  
                return textOfPhilIdea;
            }
            set
            {
                if (textOfPhilIdea.Length < 3)
                {
                    throw new ArgumentException("Your philosophical idea should be longer!!!");
                }
                else if (textOfPhilIdea.Length > 400)
                {
                    throw new ArgumentException("Please, write a shorter philosophical idea!!!");
                }
                else
                {
                    this.textOfPhilIdea = value;
                }
            }
        }
    }
}

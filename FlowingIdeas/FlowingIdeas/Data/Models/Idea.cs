using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowingIdeas.Data.Models
{
    /// <summary>
    /// This class is the structure for artistic, philosophical and work ideas,
    /// an abstract class is used instead of an interface due to the uses.
    /// It has an autoincremented Id, IdeaType coresponding with 1, 2 or 3,
    /// depending on the idea, userID /foreign key to the table users/
    /// </summary>
    public abstract class Idea
    {
        public int Id { get; private set; }
        public int IdeaType { get; private set; }
        public int UserId { get; private set; }
        public string textOfIdea;
        public bool isDeleted { get; set; }
        public Idea()
        {
               
        }
        public Idea(int id, int ideaType, int userId, string textOfIdea)
        {
            this.Id = id;
            this.IdeaType = ideaType;
            this.UserId = userId;
            this.TextOfIdea = textOfIdea;
            isDeleted = false;
        }

        public virtual string TextOfIdea
        {
            get
            {
                return textOfIdea;
            }
            set
            {
                if (textOfIdea.Length < 3)
                {
                    throw new ArgumentException("Please, write a longer idea!!!");
                }
                else if (textOfIdea.Length > 400)
                {
                    throw new ArgumentException("Please, write a shorter idea!!!");
                }
                else
                {
                    this.textOfIdea = value;
                }
            }
        }
    }
}

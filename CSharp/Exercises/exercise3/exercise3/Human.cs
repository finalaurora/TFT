namespace exercise3
{
    abstract class Human
    {
        protected Human(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        protected Human()
        {
            FirstName = "";
            LastName = "";
        }
        protected string FirstName
        {
            get; set;
        }
        protected string LastName
        {
            get; set;
        }
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
        public static bool operator >(Human first, Human second)
        {
            if (first.FirstName.ToLower().CompareTo(second.FirstName.ToLower()) > 0)
            {
                return true;
            }
            else if (first.FirstName.ToLower().CompareTo(second.FirstName.ToLower()) == 0 && first.LastName.ToLower().CompareTo(second.LastName.ToLower()) > 0)
            {
                return true;
            }
            else
                return false;
        }
        public static bool operator <(Human first, Human second)
        {
            if (first.FirstName.ToLower().CompareTo(second.FirstName.ToLower()) < 0)
            {
                return true;
            }
            else if (first.FirstName.ToLower().CompareTo(second.FirstName.ToLower()) == 0 && first.LastName.ToLower().CompareTo(second.LastName.ToLower()) < 0)
            {
                return true;
            }
            else
                return false;
        }
    }

}

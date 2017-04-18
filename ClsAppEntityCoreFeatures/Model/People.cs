using System.Collections.Generic;

namespace ClsAppEntityCoreFeatures.Model
{
    public class People
    {
        public People()
        {
            Phones = new HashSet<Phone>();
        }

        public int PeopleId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Phone> Phones { get; set; }
    }
}

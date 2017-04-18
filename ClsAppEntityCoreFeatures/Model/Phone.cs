namespace ClsAppEntityCoreFeatures.Model
{
    public class Phone
    {
        public int PhoneId { get; set; }
        public string Number { get; set; }

        public virtual People People { get; set; }
    }
}

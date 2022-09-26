namespace ConsoleAppExceptionHandler.Factory {
    public class CountryDiscountService : DiscountService {

        private readonly string _countryIdentifier;
        public CountryDiscountService(string countryIdentifier) {
            _countryIdentifier = countryIdentifier;
        }
        public override int DiscountPercentage {
            get {
                switch(_countryIdentifier){
                    // if you're from Belgium, you get a better discount :)
                    case "BE":
                        return 20;
                    default:
                        return 10;
                };
            }
        }
    }
}

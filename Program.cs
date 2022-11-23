
using internetServiceProvider;

class main
{
    public static void Main(string[] args)
    {
        InternetServiceProvider isp = new InternetServiceProvider();
        ///myobj.setCustomerdetails(1,"Animesh");
        isp.CustomerDetails(2, "Animesh", 20);
        /// myobj.getCustomerdetails();
        isp.SecondaryCustomerDetails();
        ChangeBandWidths bWidths = new ChangeBandWidths();
        bWidths.BandWidth();
        ISpeed netSpeed = new ISpeed();
        netSpeed.SpeedLimit();
    }
}
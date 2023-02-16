using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPart6
{
    public partial class FakeDataTest : Form
    {
        public FakeDataTest()
        {
            InitializeComponent();
        }

        private void FakeDataTest_Load(object sender, EventArgs e)
        {
            //Person Data
            string maleName = FakeData.NameData.GetMaleFirstName();
            string femaleName = FakeData.NameData.GetFemaleFirstName();


            string maleOrFemaleName = FakeData.NameData.GetFirstName();
            string surname = FakeData.NameData.GetSurname();
            string fullname = FakeData.NameData.GetFullName();

            //Other Data
            string companyName = FakeData.NameData.GetCompanyName();
            bool booleanData = FakeData.BooleanData.GetBoolean();
            DateTime date1 = FakeData.DateTimeData.GetDatetime();

            //Place Data
            var country = FakeData.PlaceData.GetCountry();
            var state = FakeData.PlaceData.GetState();
            var city = FakeData.PlaceData.GetCity();
            var county = FakeData.PlaceData.GetCounty();
            var postCode = FakeData.PlaceData.GetPostCode();
            var zipCode = FakeData.PlaceData.GetZipCode();
            var streetName = FakeData.PlaceData.GetStreetName();
            var streetNumber = FakeData.PlaceData.GetStreetNumber();
            var address = FakeData.PlaceData.GetAddress();

            //Phone Data
            var phone1 = FakeData.PhoneNumberData.GetInternationalPhoneNumber();
            var phone2 = FakeData.PhoneNumberData.GetUsPhoneNumber();
            var phone3 = FakeData.PhoneNumberData.GetPhoneNumber();

            //Text Data
            var text1 = FakeData.TextData.GetAlphabetical(500);
            var text2 = FakeData.TextData.GetAlphaNumeric(500);
            var text3 = FakeData.TextData.GetNumeric(100);


            VirtualDatabase db = new VirtualDatabase();
            List<Customer> customers = db.GetCustomers(100);
        }
    }
}

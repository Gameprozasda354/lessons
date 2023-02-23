using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Homework
{
    public partial class Form1 : Form
    {

        CountriesDataBase countriesDtb = new CountriesDataBase();

        public Form1()
        {
            InitializeComponent();
            if (!Directory.Exists(@"C:/Countries"))
            {
                DirectoryInfo directory = Directory.CreateDirectory(@"C:/Countries");
            }
        }
        private void GeneratePersons(object sender, EventArgs e)
        {
            DataBase db = new DataBase();

            Random random = new Random();

            for (int i = 0; i < 1000; i++)
            {
                string name = FakeData.NameData.GetFirstName();
                string surName = FakeData.NameData.GetSurname();
                string agePrefix = "";
                Person person = new Person()
                {
                    Name = name,
                    SurName = surName,
                    Age = random.Next(1, 100),
                    Email = FakeData.NetworkData.GetEmail(name, surName),
                    Country = FakeData.PlaceData.GetCountry(),
                };
                if(person.Age <= 18)
                {
                    agePrefix = "0-18";
                }
                else if(person.Age > 18 && person.Age <= 35)
                {
                    agePrefix = "19-35";
                }
                else if(person.Age > 35 && person.Age <= 60)
                {
                    agePrefix = "36-60";
                }
                else
                {
                    agePrefix = "60+";
                }
                
                if(!Directory.Exists(@"C:/Countries/" + person.Country))
                {
                    DirectoryInfo dirInfo = Directory.CreateDirectory(@"C:/Countries/" + person.Country);
                    if(!Directory.Exists($@"C:/Countries/{person.Country}/{agePrefix}"))
                    {
                        DirectoryInfo directoryInfo = Directory.CreateDirectory($@"C:/Countries/{person.Country}/{agePrefix}");
                    }
                    bool contains = false;
                    foreach (Country item in countriesDtb.countriesList)
                    {
                        if(item.CountryName == person.Country)
                        {
                            contains = true;
                            item.PersonCount += 1;
                            if (person.Age <= 18)
                            {
                                item.Age_0_18++;
                            }
                            else if (person.Age > 18 && person.Age <= 35)
                            {
                                item.Age_19_35++;
                            }
                            else if (person.Age > 35 && person.Age <= 60)
                            {
                                item.Age_36_60++;
                            }
                            else
                            {
                                item.Age_60up++;
                            }
                        }
                    }

                    if (!contains)
                    {
                        Country country = new Country()
                        {
                            PersonCount = 1,
                            CountryName = person.Country
                        };
                        if (person.Age <= 18)
                        {
                            country.Age_0_18++;
                        }
                        else if (person.Age > 18 && person.Age <= 35)
                        {
                            country.Age_19_35++;
                        }
                        else if (person.Age > 35 && person.Age <= 60)
                        {
                            country.Age_36_60++;
                        }
                        else
                        {
                            country.Age_60up++;
                        }
                        countriesDtb.countriesList.Add(country);
                    }
                    string directory = $@"C:/Countries/{person.Country}/{agePrefix}/{person.Name}-{person.SurName}-{Guid.NewGuid()}.txt";
                    FileStream fileStream = File.Create(directory);
                    fileStream.Close();
                }
                else
                {
                    if (!Directory.Exists($@"C:/Countries/{person.Country}/{agePrefix}"))
                    {
                        DirectoryInfo directoryInfo = Directory.CreateDirectory($@"C:/Countries/{person.Country}/{agePrefix}");
                    }
                    string directory = $@"C:/Countries/{person.Country}/{agePrefix}/{person.Name}-{person.SurName}-{Guid.NewGuid()}.txt";
                    bool contains = false;
                    foreach (Country item in countriesDtb.countriesList)
                    {
                        if (item.CountryName == person.Country)
                        {
                            contains = true;
                            item.PersonCount += 1;
                            if (person.Age <= 18)
                            {
                                item.Age_0_18++;
                            }
                            else if (person.Age > 18 && person.Age <= 35)
                            {
                                item.Age_19_35++;
                            }
                            else if (person.Age > 35 && person.Age <= 60)
                            {
                                item.Age_36_60++;
                            }
                            else
                            {
                                item.Age_60up++;
                            }
                        }
                    }
                    if (!contains)
                    {
                        Country country = new Country()
                        {
                            PersonCount = 1,
                            CountryName = person.Country
                        };
                        if (person.Age <= 18)
                        {
                            country.Age_0_18++;
                        }
                        else if (person.Age > 18 && person.Age <= 35)
                        {
                            country.Age_19_35++;
                        }
                        else if (person.Age > 35 && person.Age <= 60)
                        {
                            country.Age_36_60++;
                        }
                        else
                        {
                            country.Age_60up++;
                        }
                        countriesDtb.countriesList.Add(country);
                    }
                    FileStream fileStream = File.Create(directory);
                    fileStream.Close();
                }
                db.persons.Add(person);
            }
            personsDataGridView.DataSource = db.persons;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonsStatistics personsStatistics = new PersonsStatistics(countriesDtb.countriesList);
            personsStatistics.ShowDialog();
        }
    }
}

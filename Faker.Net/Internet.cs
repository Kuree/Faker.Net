using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Faker.Locales;
using System.Web.Security;
using System.Drawing;
using Random = Faker.Random;

namespace Faker
{
    public class Internet : FakerBase
    {
        public Internet() : base() { }
        public Internet(LocaleType type) : base(type) { }

        // default static interface
        public static Internet Default { get { return defaultValue; } }
        private static Internet defaultValue = new Internet();

        public virtual string GetPassword() { return this.GetPassword(15); }
        public virtual string GetPassword(int length)
        {
            return Membership.GeneratePassword(length, length << 2);
        }

        public virtual string GetAvatarURL()
        {
            return @"https://s3.amazonaws.com/uifaces/faces/twitter/" + Random.Selector.GetRandomItemFromList<string>(this.locale.AvatarURL);
        }

        public virtual Color GetColorRGB()
        {
            return Color.FromArgb(Random.RandomProxy.Next(256), Random.RandomProxy.Next(256), Random.RandomProxy.Next(256));
        }

        public virtual Color GetColorARGB()
        {
            return Color.FromArgb(Random.RandomProxy.Next(256), Random.RandomProxy.Next(256), Random.RandomProxy.Next(256), Random.RandomProxy.Next(256));
        }

        public virtual string GetColorString()
        {
            return string.Format("#{0:X8}", this.GetColorARGB().ToArgb());
        }

        public virtual string GetUserName()
        {
            return this.GetUserName(Name.Default.GetFirstName(), Name.Default.GetLastName());
        }

        public virtual string GetUserName(string firstName, string lastName)
        {
            switch (Random.RandomProxy.Next(3))
            {
                case 0:
                    return firstName + Random.RandomProxy.Next(100).ToString();
                case 1:
                    return string.Format("{0}{1}{2}", firstName, Random.Selector.GetRandomItemFromList<string>(new string[] { ".", "_" }),
                        lastName);
                default:
                    return string.Format("{0}{1}{2}{3}", firstName, Random.Selector.GetRandomItemFromList<string>(new string[] { ".", "_" }),
                        lastName, Random.RandomProxy.Next(100));
            }
        }

        public virtual string GetEmail(string firstName, string lastName)
        {
            return this.GetUserName(firstName, lastName) + "@" + Random.Selector.GetRandomItemFromList<string>(locale.FreeEmailDomain);
        }

        public virtual string GetEmail()
        {
            return this.GetEmail(Name.Default.GetFirstName(), Name.Default.GetLastName());
        }

        public virtual string GetIP()
        {
            return string.Format("{0}.{1}.{2}.{3}", Random.RandomProxy.Next(256), Random.RandomProxy.Next(256), Random.RandomProxy.Next(256),
                Random.RandomProxy.Next(256));
        }

        public virtual string GetDomainWord()
        {
            return Random.Selector.GetRandomItemFromList<string>(locale.FirstName).ToLower();
        }

        public virtual string GetDomainName()
        {
            return this.GetDomainWord() + "." + this.GetDomainSuffix();
        }

        public virtual string GetDomainSuffix()
        {
            return Random.Selector.GetRandomItemFromList<string>(locale.DomainSuffix);
        }
        
        private string randInt(int minValue, int maxValue)
        {
            return Random.RandomProxy.Next(minValue, maxValue).ToString();
        }

        private string GetUserAgent()
        {
            // Code adopted from http://www.hackforums.net/archive/index.php/thread-1568584.html
            // Also update some new versions

            string[] arrBrowsers = {"Firefox/0."+randInt(7,9)+"."+randInt(0,5),
                                    "Outlook-Express/" + randInt(5,8) + "." + randInt(0,5),
                                    "Opera/"+randInt(7,9) + "." + randInt(1,80),
                                    "Safari/4"+randInt(1,15) + "." + randInt(1,6),
                                    "Arora/0."+randInt(1,5),
                                    "Gecko/200"+randInt(0,9024)+"Firefox/3."+randInt(1,6),
                                    "Lynx/2."+randInt(1,8)+"."+randInt(2,5)+"dev."+randInt(1,16),
                                    "Chrome/" + randInt(10, 35) + ".0."+randInt(0,154)+"."+randInt(0,60)};

            string[] arrOS = {  "Windows NT 5.1",
                                "Windows NT 6.1",
                                "Windows NT 6.0",
                                "Windows NT 6.3",
                                "Windows",
                                "Windows 95",
                                "Windows 98",
                                "FreeBSD i686",
                                "Ubuntu i686",
                                "Macintosh",
                                "Linux"};

            string[] arrPlugins = {   "MS-RTC LM "+randInt(4,8)+";",
                                      "Win64;",
                                      "x64;",
                                      "Trident/"+randInt(4,6)+".0;",
                                      "SLCC2;",
                                      ".NET CLR "+randInt(2,4)+"."+randInt(1,7)+".30"+randInt(50,500)+";",
                                      "Media Center PC "+randInt(0,6)+".0;",
                                      "Tablet PC "+randInt(1,3)+".0;",
                                      "Presto/2."+randInt(0,2)+"."+randInt(0,9),
                                      "rv:1."+randInt(1,5)+"."+randInt(1,9)+";",
                                      "WOW64;",
                                      "GTB"+randInt(5,7)+";",
                                      "WebTV/2."+randInt(0,9)+";",
                                      "AppleWebKit/"+randInt(500,550)+"."+randInt(1,50)+" (KHTML, like Gecko)",
                                      "Zune "+randInt(1,4)+".0;",
                                      "msn OptimizedIE"+randInt(5,8)+";",
                                      "OfficeLiveConnector.1."+randInt(1,9)+";",
                                      "OfficeLivePatch.0."+randInt(0,5)+";",
                                      "AskTB5."+randInt(0,7),
                                      "MS-RTC LM "+randInt(5,8)+";",
                                      "InfoPath."+randInt(1,4)+";",
                                      ".NET"+randInt(2,4)+".0C;"};

            string strPlugins = String.Empty;
            int plugincount = Random.RandomProxy.Next(3, 6);
            int[] history = new int[plugincount];
            for (int i = 0; i != plugincount; i++)
            {
                int ran = Random.RandomProxy.Next(0, arrPlugins.Length);
                if (!history.Contains(ran))
                {
                    history[i] = ran;
                    strPlugins = strPlugins + " " + arrPlugins[ran];
                }
                else
                {
                    i--;
                }
            }
            string Type = "Mozilla/" + randInt(4, 6) + ".0";
            string OS = arrOS[Random.RandomProxy.Next(0, arrOS.Length)];
            string[] arrCompatible = { "compatible; MSIE " + randInt(6, 10) + ".0; ", "", "" };
            string Compatible = arrCompatible[Random.RandomProxy.Next(0, 1)];
            if (OS.IndexOf("Linux") != -1 || OS.IndexOf("Ubuntu") != -1 || OS.IndexOf("FreeBSD") != -1 || OS.IndexOf("Macintosh") != -1) { Compatible = ""; } //remove the compatible MSIE message from the string
            return Type + " (" + Compatible + OS + ";" + strPlugins + " " + arrBrowsers[Random.RandomProxy.Next(0, arrBrowsers.Length)] + " )";
        }


    }
}

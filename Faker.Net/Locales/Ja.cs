using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Faker.Locales
{
    [LocaleAttribute(Faker.LocaleType.ja)]
    internal class Ja : En
    {
        public override string Title { get { return "Japanese"; } }

        #region Geography
        public override string[] PostCode
        {
            get
            {
                return new string[] { 
                                     "###-####"
                };
            }
        }

        public override string[] State
        {
            get
            {
                return new string[] { 
                                    "北海道",
                                    "青森県",
                                    "岩手県",
                                    "宮城県",
                                    "秋田県",
                                    "山形県",
                                    "福島県",
                                    "茨城県",
                                    "栃木県",
                                    "群馬県",
                                    "埼玉県",
                                    "千葉県",
                                    "東京都",
                                    "神奈川県",
                                    "新潟県",
                                    "富山県",
                                    "石川県",
                                    "福井県",
                                    "山梨県",
                                    "長野県",
                                    "岐阜県",
                                    "静岡県",
                                    "愛知県",
                                    "三重県",
                                    "滋賀県",
                                    "京都府",
                                    "大阪府",
                                    "兵庫県",
                                    "奈良県",
                                    "和歌山県",
                                    "鳥取県",
                                    "島根県",
                                    "岡山県",
                                    "広島県",
                                    "山口県",
                                    "徳島県",
                                    "香川県",
                                    "愛媛県",
                                    "高知県",
                                    "福岡県",
                                    "佐賀県",
                                    "長崎県",
                                    "熊本県",
                                    "大分県",
                                    "宮崎県",
                                    "鹿児島県",
                                    "沖縄県"
                };
            }
        }

        public override string[] StateAbbr
        {
            get
            {
                return new string[] { 
                                    "1",
                                    "2",
                                    "3",
                                    "4",
                                    "5",
                                    "6",
                                    "7",
                                    "8",
                                    "9",
                                    "10",
                                    "11",
                                    "12",
                                    "13",
                                    "14",
                                    "15",
                                    "16",
                                    "17",
                                    "18",
                                    "19",
                                    "20",
                                    "21",
                                    "22",
                                    "23",
                                    "24",
                                    "25",
                                    "26",
                                    "27",
                                    "28",
                                    "29",
                                    "30",
                                    "31",
                                    "32",
                                    "33",
                                    "34",
                                    "35",
                                    "36",
                                    "37",
                                    "38",
                                    "39",
                                    "40",
                                    "41",
                                    "42",
                                    "43",
                                    "44",
                                    "45",
                                    "46",
                                    "47"
                };
            }
        }

        public override string[] CityPrefix
        {
            get
            {
                return new string[] { 
                                    "北",
                                    "東",
                                    "西",
                                    "南",
                                    "新",
                                    "湖",
                                    "港"
                };
            }
        }

        public override string[] CitySuffix
        {
            get
            {
                return new string[] { 
                                    "市",
                                    "区",
                                    "町",
                                    "村"
                };
            }
        }

        public override string[] CityNameFormat
        {
            get
            {
                return new string[] { 
                                    "#{CityPrefix}@{Name.GetLastName}#{CitySuffix}",
                                    "@{Name.GetFirstName}#{CitySuffix}",
                                    "#{CityPrefix}@{Name.GetLastName}#{CitySuffix}",
                                    "@{Name.GetLastName}#{CitySuffix}"
                };
            }
        }

        public override string[] StreetNameFormat
        {
            get
            {
                return new string[] { 
                                     "@{Name.GetLastName}#{StreetSuffix}",
                                     "@{Name.GetLastName}#{StreetSuffix}"
                };
            }
        }

        public override bool HasFullStreetAddress
        {
            get
            {
                return false;
            }
        }
        #endregion

        #region Phone Number
        public override string[] PhoneNumberFormat
        {
            get
            {
                return new string[] { 
                                   "0####-#-####",
                                    "0###-##-####",
                                    "0##-###-####",
                                    "0#-####-####"
                };
            }
        }
        #endregion

        #region Name
        public override string[] LastName
        {
            get
            {
                return new string[] { 
                                     "佐藤",
                                    "鈴木",
                                    "高橋",
                                    "田中",
                                    "渡辺",
                                    "伊藤",
                                    "山本",
                                    "中村",
                                    "小林",
                                    "加藤",
                                    "吉田",
                                    "山田",
                                    "佐々木",
                                    "山口",
                                    "斎藤",
                                    "松本",
                                    "井上",
                                    "木村",
                                    "林",
                                    "清水"
                };
            }
        }

        public override string[] FirstName
        {
            get
            {
                return new string[] { 
                                   "大翔",
                                    "蓮",
                                    "颯太",
                                    "樹",
                                    "大和",
                                    "陽翔",
                                    "陸斗",
                                    "太一",
                                    "海翔",
                                    "蒼空",
                                    "翼",
                                    "陽菜",
                                    "結愛",
                                    "結衣",
                                    "杏",
                                    "莉子",
                                    "美羽",
                                    "結菜",
                                    "心愛",
                                    "愛菜",
                                    "美咲"
                };
            }
        }

        public override string[] NameFormat
        {
            get
            {
                return new string[] { 
                                   "@{Name.GetLastName} @{Name.GetFirstName}"
                };
            }
        }
        #endregion
    }
}

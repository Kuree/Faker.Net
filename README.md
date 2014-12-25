# Faker.Net - Generate massive amounts of fake data in .NET
<img src = "http://imgur.com/KiinQ.png" border = "0">

## **Localizations**
Here are currently supported languages, more languages are porting into Faker.Net
* English
* English (UK)
* English (US)
* English (Bork)
* English (Canada)
* English (Australia)
* English (India)
* German
* Spanish
* Farsi
* Japanese
* French
* Italian
* Korean

## **API**
* **Address**
 * GetCityPrefix
 *  GetCitySuffix
 *  GetCityName
 *  GetStreetName
 *  GetStreetAddress
 *  GetSecondStreetAddress
 *  GetCounty
 *  GetCountry
 *  GetCountryCode
 *  GetState
 *  GetStateAbbr
 *  GetLatitude
 *  GetLongitute
 *  GetZipCode
 *  GetTimeZone
* **Company**
 * GetCompanyName
 * GetCompanySuffix
 * GetCatchPhraseAdjective
 * GetCatchPhraseDescriptor
 * GetCatchPhraseNoun
 * GetCatchPhase
* **Date**
 * GetPast
 * GetFuture
 * GetRecent
 * GetDateBetween
* **Finance**
 * GetAccountName
 * GetAccount
 * GetTransactionType
 * GetCurrencyName
 * GetCurrencyCode
 * GetCurrencySymbol
* **Hacker**
 * HackerNoun
 * HackerVerb
 * HackerAdjective
 * HackerAbbreviat
 * HackerIngVerb
 * HackerPhrase
* **Image**
 * GetAvatarURL
 * GetImageURL
* **Internet**
 * GetPassword
 * GetAvatarURL
 * GetColorRGB
 * GetColorARGB
 * GetColorString
 * GetUserName
 * GetEmail
 * GetIP
 * GetDomainWord
 * GetDomainName
 * GetDomainSuffix
* **Lorem**
 * GetWords
 * GetSentence
 * GetSentences
 * GetParagraph
 * GetParagraphs
* **Name**
 * GetLastName
 * GetFirstName
 * GetName
* **PhoneNumber**
 * GetPhoneNumber

## Usage
Each faker class inherits FakerBase, and by design are not static. However, they all have a static Default member (English) to access if you don't want to create the class object.

## Faker.js
This project is not a line-for-line conversion from faker.js, though most of its data source comes from faker.js. The philosophy behinds the conversion is to make it as intelligent as possible. Heavily used Regex and Reflection makes the library easy to maintain and update in .NET framework.

The copyright statement from faker.js. 

> Matthew Bergman & Marak Squires
> <br/>
Copyright (c) 2014 Matthew Bergman & Marak Squires http://github.com/marak/faker.js/
<br/>
faker.js was inspired by and has used data definitions from
<br/>
  https://github.com/stympy/faker/ - Copyright (c) 2007-2010 Benjamin Curtis <br/>
  http://search.cpan.org/~jasonk/Data-Faker-0.07/ - Copyright 2004-2005 by Jason Kohles <br/>
> Permission is hereby granted, free of charge, to any person obtaining
a copy of this software and associated documentation files (the
"Software"), to deal in the Software without restriction, including
without limitation the rights to use, copy, modify, merge, publish,
distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so, subject to
the following conditions:
> <br/>
The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.
<br/>
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

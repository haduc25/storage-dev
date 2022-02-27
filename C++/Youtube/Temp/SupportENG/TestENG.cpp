#include <iostream>
 

using namespace std;
string Therelesson = "Are there lessons on...(Monday/Tuesday/Wednesday/Thursday/Friday/Saturday/Sunday)?";
string Whenlesson ="When can I take lessons?"; //When
string Agelesson ="Are there lessons for (Age)-year-olds?"; //Age
string Free = "Is it free?";
string Find = "1.Can I find...(do vat)..there?\n2.I ca find what?";
string telephone = "What is the telephone number?"; //telephone
string address = "1.Can you tell me the address?\n2.What is the address?"; //address
string opene = "Is it open/close in the evenings?"; //open/close/evenings
string arethere = "Are there any...(music magazines?)"; //are/there/any
string bring = "Can I bring my...(dog)?";//bring/animal
string web = "What is the website?"; //web/what
string cafe1 = "What is the name of the cafe?"; //name/what
string cafe = "Where is the cafe?";//where/cafe
string food = "What food can I buy there?"; //what/food/buy/there
string Whenoc = "When does it open/close?";
string Wheree = "Where can you eat there?";
string Wherer = "Where is the restaurant?";
string wear = "1.Should I wear special clothes?\n2.Do I need to wear special clothes?";
string What = "What can do there?";
string Where = "Where is it?\n-Is is located on...(Dia Diem)";
string Where1 = "Where is the...(cooking,party,comtation,project)?\n-It is...";
string Whereb = "Where i can buy(the Tickets)";
string When = "When is it?\n-It is on...(Monday/Tuesday/Wednesday/Thursday/Friday/Saturday/Sunday)";
string Which = "Which activity does it have?\n-Is has...";
string Which1 ="Which service does it have?\n-It has...(Transfers/Withdraw/saving/Exchange)";
string Timeoc = "-It (open/close) at... (Am/Pm)";
string Timeoc1  = "What time does it open/close?";
string Timeopen = "Does it open on (Monday/Tuesday/Wednesday/Thursday/Friday/Saturday/Sunday)\n1.-Actually, it is only close on (Monday/Tuesday/Wednesday/Thursday/Friday/Saturday/Sunday)\n2.-Yes,It is open";
string Carpark = "1.Does it have car park\n-Free car park for (number) cars\n2.Is there a car park?";
string Cost = "How much does it cost?\n-Price it is...(Pao/$)";
string Finish = "What time does it finish?\n-It finish at...(am/pm)";
string Does = "Does it have....(Live Music/Food/Drinks/Food and Drinks)\n-Yes,It does";
string Whatc = "What is cost of...(Adult/Studen)Tickets?\n-It is spend $/£..($/£(Pao))";
string Whatc1 ="How much are the (Adult/Studen) tickets?\nIt is spend $/£..($/£(Pao))";
string Ticketfree = "Are there free tickets for students?";
string Ticket = "How much is a...(Adult/student) ticket?";
string Expensive ="It have Expensive?\n1.-Yes\n2.-No";
string ocm = "It is Open/Close in..(Month)";
string Buy = "Can I buy there?";
string Buy1 = "1.What can buy/sell at the...?\n2.What does it sell?";
string When1 = "When does it begin?";
string Timese = "What time does it start/end?";
string Howt = "How much is a...(ticket)?";
string Houc = "How much are the...(guitar) lessons?";
string oce = "Is it open every day?";
string Age ="Is it available for everyone?\n-definitely not, it’s only for young people from 10 to 18 years old";
string Many = "How many...(Markets,Restauran,Cafe,Bank,Dishe)\n-More than...(Number)..(Markets,Restauran,Cafe,Bank,Dishe))";
int main()
{
	//	cout<<"\n\n===()===\n";
	int n;
	cout<<("1.Bank\n2.Cafe\n3.City\n4.Restaurant\n5.Market\n6.School\n7.Subject\n8.Party\n9.Competion\n10.Food\n11.Cooking\n12.Lesson");
	cout<<("\n===(Select)===\n");
	cin>>n;
	switch(n){

	case 1:
		{
			cout<<"\n|=====(Bank)=====|\n";
			cout<<"\n\n===(Name)===\nWhat is Bank's name?\n1.Name it is...\n2.We call it...";
			cout<<"\n\n===(Where)===\n1."<<Where<<"2.Where is the Bank\n-It is...";
			cout<<"\n\n===(When)===\n"<<When;
			cout<<"\n\n===(What/do/There)===\n"<<What;
			cout<<"\n\n===(Which/Service)===\n"<<Which1;
			cout<<"\n\n===(Finish)===\n"<<Finish;
			cout<<"\n\n===(Open/Close/Everyday/Week)===\n"<<oce;
			cout<<"\n\n===(Open/Close/Month)===\n"<<ocm;
			cout<<"\n\n===(What/When/Time/Open/Close)===\n1.Does it open in the (afternoon/morning)? (open/afternoon/morning)\n"<<Timeoc<<"\n2.What time will Bank (open/close)\n"<<Timeoc<<"\n3.When is the Bank (open/close)?\n"<<Timeoc<<"\n4."<<Whenoc;
			cout<<"\n\n===(Time)===\n"<<Timeopen;
			cout<<"\n\n===(What/Time/Open/Close)===\n"<<Timeoc1;
			cout<<"\n\n===(Wear)===\nWhat to Wear to Bank\n-It is...(Must wear a costume)";
			cout<<"\n\n===(Wear)===\n"<<wear;
			cout<<"\n\n===(Change Money)===\nDoes it change money?/n-Yes,it does...";
			cout<<"\n\n===(Car Park)===\n"<<Carpark;
			cout<<"\n\n===(Cost===)\n"<<Cost;
			cout<<"\n\n===(Telephone)===\n"<<telephone;
			cout<<"\n\n===(Website)===\n"<<web;
			cout<<"\n\n===(How/Many)===\n"<<Many;
			cout<<"\n\n===(Address,Link,Website)===\n1.Where is the Bank (Address/Link/Website)?\n-It is at...\n"<<address;
			break;
		}
	case 2:
		{
			cout<<"Cafe";
			cout<<"\n\n===(Name/What)===\n"<<cafe1;
			cout<<"\n\n===(Where/Open)===\n"<<cafe;
			cout<<"\n\n===(Time/Oppen/Close/Everyday)===\n"<<ocm<<"\n"<<Timeopen<<"\n"<<Timeoc1<<"\n"<<oce;
			cout<<"\n\n===(Finish)===\n"<<Finish;
			cout<<"\n\n===(When/Open/Close)===\n"<<When<<"\n"<<Whenoc;
			cout<<"\n\n===(Does/Drink)===\n"<<Does;
			cout<<"\n\n===(Buy/Shell)===\n"<<Buy<<"\n"<<Buy1<<"\n3.I can buy/sell What?";
			cout<<"\n\n===(How/Many)===\n"<<Many;
			cout<<"\n\n===(Cost/How)===\n"<<Cost;
			cout<<"\n\n===(Cost/Tickets(Adult/Studen))===\n"<<Whatc;
			cout<<"\n\n===(Cost/Tickets)===\n"<<Whatc1;
			cout<<"\n\n===(Free Tickets/Students?)===\n"<<Ticketfree;
			cout<<"\n\n===(Where/Tickets)===\n"<<Whereb;
			cout<<"\n\n===(Buy)===\n"<<Buy;
			cout<<"\n\n===(What/Buy/Sell)===\n"<<Buy1;
			cout<<"\n\n===(Expensive)===\n"<<Expensive;
			cout<<"\n\n===(Wear)===\n"<<wear;
			cout<<"\n\n===(Car Park)===\n"<<Carpark;
			cout<<"\n\n===(Telephone)===\n"<<telephone;
			cout<<"\n\n===(Website)===\n"<<web;
			cout<<"\n\n===(Address,Link,Website)===\n1.Where is the cafe(Address/Link/Website)?\n-It is at...\n"<<address;
						
			break;
		}
	case 3:
		{
			cout<<"City";
			break;
		}
	case 4:
		{
			cout<<"Restaurant";
			cout<<"\n\n===(Name)===\nWhat is Restaurant's name?\n1.Name it is...\n2.We call it...";
			cout<<"\n\n===(Where)===\n1."<<Where<<"2.Where is the...\n-It is...";
			cout<<"\n\n===(When)===\n"<<When<<"\n"<<When1;
			cout<<"\n\n===(Finish)===\n"<<Finish;
			cout<<"\n\n===(Which/Activity)===\n"<<Which;
			cout<<"\n\n===(Time/Oppen/Close/Everyday)===\n"<<ocm<<"\n"<<Timeopen<<"\n"<<Timeoc1<<"\n"<<oce;
			cout<<"\n\n===(How/Cost)===\n"<<Cost;
			cout<<"\n\n===(Expensive)===\n"<<Expensive;
			cout<<"\n\n===(Cost/Ticket/Free)===\n1."<<Ticket<<"\n2."<<Ticketfree;
			cout<<"\n\n===(Buy/Shell)===\n"<<Buy<<"\n"<<Buy1<<"\n3.I can buy/sell What?";
			cout<<"\n\n===(Does)===\n"<<Does;
			cout<<"\n\n===(How/Many)===\n"<<Many;
			cout<<"\n\n===(Car Park)===\n"<<Carpark;
			cout<<"\n\n===(Cost/Tickets(Adult/Studen))===\n"<<Whatc;
			cout<<"\n\n===(Cost/Tickets)===\n"<<Whatc1;
			cout<<"\n\n===(Free Tickets/Students?)===\n"<<Ticketfree;
			cout<<"\n\n===(Where/Tickets)===\n"<<Whereb;
			cout<<"\n\n===(Wear)===\n"<<wear;
			cout<<"\n\n===(Telephone)===\n"<<telephone;
			cout<<"\n\n===(Website)===\n"<<web;
			cout<<"\n\n===(Address,Link,Website)===\n1.Where is the cooking(Address/Link/Website)?\n-It is at...\n"<<address;
			break;
		}
	case 5:
		{
			cout<<"Market";
			cout<<"\n\n===(Name)===\nWhat is Market's name?\n1.Name it is...\n2.We call it...";
			cout<<"\n\n===(Where)===\n1."<<Where<<"2.Where is the...\n-It is...";
			cout<<"\n\n===(When)===\n"<<When<<"\n"<<When1;
			cout<<"\n\n===(Finish)===\n"<<Finish;
			cout<<"\n\n===(Which/Activity)===\n"<<Which;
			cout<<"\n\n===(Time/Oppen/Close/Everyday)===\n"<<ocm<<"\n"<<Timeopen<<"\n"<<Timeoc1<<"\n"<<oce;
			cout<<"\n\n===(How/Cost)===\n"<<Cost;
			cout<<"\n\n===(Expensive)===\n"<<Expensive;
			cout<<"\n\n===(Cost/Ticket/Free)===\n1."<<Ticket<<"\n2."<<Ticketfree;
			cout<<"\n\n===(Buy/Shell)===\n"<<Buy<<"\n"<<Buy1<<"\n3.I can buy/sell What?";
			cout<<"\n\n===(Does)===\n"<<Does;
			cout<<"\n\n===(How/Many)===\n"<<Many;
			cout<<"\n\n===(Find)===\n"<<Find;
			cout<<"\n\n===(Free)===\n"<<Free;
			cout<<"\n\n===(Car Park)===\n"<<Carpark;
			cout<<"\n\n===(Cost/Tickets(Adult/Studen))===\n"<<Whatc;
			cout<<"\n\n===(Cost/Tickets)===\n"<<Whatc1;
			cout<<"\n\n===(Free Tickets/Students?)===\n"<<Ticketfree;
			cout<<"\n\n===(Where/Tickets)===\n"<<Whereb;
			cout<<"\n\n===(Wear)===\n"<<wear;
			cout<<"\n\n===(Telephone)===\n"<<telephone;
			cout<<"\n\n===(Website)===\n"<<web;
			cout<<"\n\n===(Address,Link,Website)===\n1.Where is the cooking(Address/Link/Website)?\n-It is at...\n"<<address;
			break;
		}
    case 6:
		{
			cout<<"School";
			cout<<"\n\n===(Name)===\n1.What is School's name?\n-1.Name it is...\n-2.We call it...\n2.What is name of the school";
			cout<<"\n\n===(Where)===\n1."<<Where<<"2.Where is the...\n-It is...";
			cout<<"\n\n===(When)===\n"<<When<<"\n"<<When1;
			cout<<"\n\n===(Finish)===\n"<<Finish;
			cout<<"\n\n===(Which/Activity)===\n"<<Which;
			cout<<"\n\n===(Time/Oppen/Close/Everyday)===\n"<<ocm<<"\n"<<Timeopen<<"\n"<<Timeoc1<<"\n"<<oce;
			cout<<"\n\n===(How/Cost)===\n"<<Cost;
			cout<<"\n\n===(Expensive)===\n"<<Expensive;
			cout<<"\n\n===(Does)===\n"<<Does;
			cout<<"\n\n===(Lear)===\nWe will be learning ?";
			cout<<"\n\n===(Class)===\nWhich class are you in?";
			cout<<"\n\n===(How/Many)===\n"<<Many;
			cout<<"\n\n===(Car Park)===\n"<<Carpark;
			cout<<"\n\n===(Wear)===\n"<<wear<<"\n-Must wear a costume";
			cout<<"\n\n===(Age)===\n1."<<Age<<"2.For Children?/Audle/n-For anyone ...(age) years old";
			cout<<"\n\n===(Telephone)===\n"<<telephone;
			cout<<"\n\n===(Website)===\n"<<web;
			cout<<"\n\n===(Address,Link,Website)===\n1.Where is the cooking(Address/Link/Website)?\n-It is at...\n"<<address;
			break;
		}
	case 7:
		{
			cout<<"Subject";
			cout<<"\n\n===(Name)===\nWhat is the subject name?\n-It is name...";
			cout<<"\n\n===(Where)===\n"<<Where;	
			cout<<"\n\n===(Wear)===\n"<<wear;
			cout<<"\n\n===(Find)===\n"<<Find;
			cout<<"\n\n===(Free)===\n"<<Free;
			cout<<"\n\n===(Age)===\n"<<Age;
			cout<<"\n\n===(Free)===\n"<<Free;
		    cout<<"\n\n===(Wear)===\n"<<wear;
			cout<<"\n\n===(Cost===)\n"<<Cost;
			cout<<"\n\n===(How/Many)===\n"<<Many;
			cout<<"\n\n===(Does)===\n"<<Does;
			cout<<"\n\n===(Telephone)===\n"<<telephone;
			cout<<"\n\n===(Address,Link,Website)===\n1.Where is the cooking(Address/Link/Website)?\n-It is at...\n"<<address;
			break;
			break;
		}
	case 8:
		{
			cout<<"Party";
			cout<<"\n\n===(Where)===\nWhere will the party take place?\n-Well you know, (Name) party will hold in...(Dia Diem)";
			cout<<"\n\n===(Where)===\n"<<Where1;
			cout<<"\n\n===(Where/Eat)===\n"<<Wheree;
			cout<<"\n\n===(When)===\n"<<When1;
			cout<<"\n\n===(Wear)===\nWhat to Wear to Bank\n-It is...(Must wear a costume)";
			cout<<"\n\n===(Whose)===\nWhose party is it?\n-Actually, (name) is the host";
			cout<<"\n\n===(Cost/Tickets(Adult/Studen))===\n"<<Whatc;
			cout<<"\n\n===(Cost/Tickets)===\n"<<Whatc1;
			cout<<"\n\n===(Cost)===\n"<<Cost;
			cout<<"\n\n===(Free Tickets/Students?)===\n"<<Ticketfree;
			cout<<"\n\n===(Where/Tickets)===\n"<<Whereb;
			cout<<"\n\n===(Buy)===\n"<<Buy;
			cout<<"\n\n===(Find)===\n"<<Find;
			cout<<"\n\n===(Free)===\n"<<Free;
			cout<<"\n\n===(Special/Price Student)===\nIs there a special price for students?";
			cout<<"\n\n===(How/Ticket)===\n"<<Ticket;
			cout<<"\n\n===(Food/Does/Drink)===\n"<<Does;
			cout<<"\n\n===(Expensive)===\n"<<Expensive;
			cout<<"\n\n===(What/Buy/Sell)===\n"<<Buy1;
			cout<<"\n\n===(How/Tickets)===\n"<<Howt;
			cout<<"\n\n===(Time/Start/End)===\n"<<Timese;
			cout<<"\n\n===(Telephone)===\n"<<telephone;
			cout<<"\n\n===(Why)===\nWhy does he/she hold the party?\nBecause he/she does...";
			cout<<"\n\n===(Dance)===\nWill they dance at the party?\n- Absolutely, people enjoy Disco at a live music in (Name)’s party ";
			
			cout<<"\n\n========Birtday Party======";
			cout<<"\n\n===(Where)===\nWhere's the birthday party ?\n-It is Grandfather's garden";
			cout<<"\n\n===(When)===\nWhen's it?/are they?\n-It is on Sunday evening";
			cout<<"\n\n===(Finish)===\n"<<Finish;
			cout<<"\n\n===(Which/Activity)===\n"<<Which;
			cout<<"\n\n===(Does/Live Music)===\n"<<Does;
			break;
		}
	case 9:
		{
			cout<<"competition";
			cout<<"\n\n===(Name)===\nWhat is competition name?";
			cout<<"\n\n===(What/Kind/Everyday)===\nWhat kinds of competition will be played everyday?";
			cout<<"\n\n===(Where)===\nWhere is the ...(Holiday Sports club)?";
			cout<<"\n\n===(Where)===\nWhere will the competition take place?\n-Well you know, (Name) party will hold in...(Dia Diem)";
			cout<<"\n\n===(Where)===\n1."<<Where<<"2.Where is the Cometion\n-It is...";
			cout<<"\n\n===(When)===\n"<<When;
			cout<<"\n\n===(Time/Start/End)===\n"<<Timese;
			cout<<"\n\n===(What/do/There)===\n"<<What;
			cout<<"\n\n===(Finish)===\n"<<Finish;
			cout<<"\n\n===(Open/Close/Everyday/Week)===\n"<<oce;
			cout<<"\n\n===(Open/Close/Month)===\n"<<ocm;
			cout<<"\n\n===(What/When/Time/Open/Close)===\n1.Does it open in the (afternoon/morning)? (open/afternoon/morning)\n"<<Timeoc<<"\n2.What time will Bank (open/close)\n"<<Timeoc<<"\n3.When is the Bank (open/close)?\n"<<Timeoc<<"\n4."<<Whenoc;
			cout<<"\n\n===(Time)===\n"<<Timeopen;
			cout<<"\n\n===(What/Time/Open/Close)===\n"<<Timeoc1;
			cout<<"\n\n===(Age)===\n1."<<Age<<"2.For Children?/Audle/n-For anyone ...(age) years old";
			cout<<"\n\n===(How/Cost)===\n"<<Cost;
			cout<<"\n\n===(Cost/Ticket/Free)===\n1."<<Ticket<<"\n2."<<Ticketfree;
			cout<<"\n\n===(Expensive)===\n"<<Expensive;
			cout<<"\n\n===(Win/What/Who)===\nWhat is the reward ? who win?";
			cout<<"\n\n===(Date)===\nWhat date does it start/end?";
			cout<<"\n\n===(Telephone)===\n"<<telephone;
			cout<<"\n\n===(Website)===\n"<<web;
			cout<<"\n\n===(How/Many)===\n"<<Many;
			cout<<"\n\n===(Car Park)===\n"<<Carpark;
			cout<<"\n\n===(Address,Link,Website)===\n1.Where is the Bank (Address/Link/Website)?\n-It is at...\n"<<address;
			break;
		}
	case 10:
		{
			cout<<"Food";
			cout<<"\n\n===(Name/Dishe)===\n1.what is dish name?";
			cout<<"\n\n===(Where)===\n1."<<Where<<"2.Where is the...\n-It is...";
			cout<<"\n\n===(When)===\n"<<When<<"\n"<<When1;
			cout<<"\n\n===(Finish)===\n"<<Finish;
			cout<<"\n\n===(Which/Activity)===\n"<<Which;
			cout<<"\n\n===(Time/Oppen/Close/Everyday)===\n"<<ocm<<"\n"<<Timeopen<<"\n"<<Timeoc1<<"\n"<<oce;
			cout<<"\n\n===(Time/Start/End)===\n"<<Timese;
			cout<<"\n\n===(How/Cost)===\n"<<Cost;
			cout<<"\n\n===(Expensive)===\n"<<Expensive;
			cout<<"\n\n===(Cost/Ticket/Free)===\n1."<<Ticket<<"\n2."<<Ticketfree;
			cout<<"\n\n===(Buy/Shell)===\n"<<Buy<<"\n"<<Buy1<<"\n3.I can buy/sell What?";
			cout<<"\n\n===(Does)===\n"<<Does;
			cout<<"\n\n===(Find)===\n"<<Find;
			cout<<"\n\n===(Free)===\n"<<Free;
			cout<<"\n\n===(Age)===\n"<<Age;
			cout<<"\n\n===(How/Many)===\n"<<Many;
			cout<<"\n\n===(Car Park)===\n"<<Carpark;
			cout<<"\n\n===(Cost/Tickets(Adult/Studen))===\n"<<Whatc;
			cout<<"\n\n===(Cost/Tickets)===\n"<<Whatc1;
			cout<<"\n\n===(Free Tickets/Students?)===\n"<<Ticketfree;
			cout<<"\n\n===(Where/Tickets)===\n"<<Whereb;
			cout<<"\n\n===(Dishe/Food)===\n1.Have any dishes...(Food)\n2.There are have...(Food)";
			cout<<"\n\n===(Wear)===\n"<<wear;
			cout<<"\n\n===(Telephone)===\n"<<telephone;
			cout<<"\n\n===(Address,Link,Website)===\n1.Where is the cooking(Address/Link/Website)?\n-It is at...\n"<<address;
			break;
		}
	case 11:
		{
			cout<<"Cooking";
			cout<<"\n\n===(Name/Dishe)===\n1.what is dish name?";
			cout<<"\n\n===(Where)===\n1."<<Where<<"2.Where is the...\n-It is...";
			cout<<"\n\n===(When)===\n"<<When<<"\n"<<When1;
			cout<<"\n\n===(Finish)===\n"<<Finish;
			cout<<"\n\n===(Which/Activity)===\n"<<Which;
			cout<<"\n\n===(Age)===\n"<<Age;
			cout<<"\n\n===(Time/Oppen/Close/Everyday)===\n"<<ocm<<"\n"<<Timeopen<<"\n"<<Timeoc1<<"\n"<<oce;
			cout<<"\n\n===(Time/Start/End)===\n"<<Timese;
			cout<<"\n\n===(How/Cost)===\n"<<Cost;
			cout<<"\n\n===(Expensive)===\n"<<Expensive;
			cout<<"\n\n===(Cost/Ticket/Free)===\n1."<<Ticket<<"\n2."<<Ticketfree;
			cout<<"\n\n===(Cost/Tickets(Adult/Studen))===\n"<<Whatc;
			cout<<"\n\n===(Cost/Tickets)===\n"<<Whatc1;
			cout<<"\n\n===(Free Tickets/Students?)===\n"<<Ticketfree;
			cout<<"\n\n===(Where/Tickets)===\n"<<Whereb;
			cout<<"\n\n===(Dishe/Food)===\n1.Have any dishes...(Food)\n2.There are have...(Food)";
			cout<<"\n\n===(Wear)===\n"<<wear;
			cout<<"\n\n===(Find)===\n"<<Find;
			cout<<"\n\n===(Free)===\n"<<Free;
			cout<<"\n\n===(How/Many)===\n"<<Many;
			cout<<"\n\n===(Does)===\n"<<Does;
			cout<<"\n\n===(Telephone)===\n"<<telephone;
			cout<<"\n\n===(Address,Link,Website)===\n1.Where is the cooking(Address/Link/Website)?\n-It is at...\n"<<address;
			break;
		}
	case 12:
		{
			cout<<"Lesson";
			cout<<"\n\n===(Name)===\nName lesson is...";
			cout<<"\n\n===(Where)===\n"<<Where;
			cout<<"\n\n===(When)===\n"<<When;
			cout<<"\n\n===(There/Time/Week/Lesson)===\n"<<Therelesson;
			cout<<"\n\n===(When/Lesson)===\n"<<Whenlesson;
			cout<<"\n\n===(Age/Lesson)===\n"<<Agelesson;
			cout<<"\n\n===(Age)===\n"<<Age;
			cout<<"\n\n===(Free)===\n"<<Free;
		    cout<<"\n\n===(Wear)===\n"<<wear;
			cout<<"\n\n===(Cost===)\n"<<Cost;
			cout<<"\n\n===(Telephone)===\n"<<telephone;
			cout<<"\n\n===(Website)===\n"<<web;
			cout<<"\n\n===(How/Many)===\n"<<Many;
			cout<<"\n\n===(Address,Link,Website)===\n1.Where is the Bank (Address/Link/Website)?\n-It is at...\n"<<address;
			break;
		}
}
		
}

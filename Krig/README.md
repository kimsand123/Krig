# Krig

*****************************************************
* Kort tilbage: 14			    				    *
*							VUNDET					*
* H A L.  22 point      Spillet kort: hjerter konge *
*							U F J R				    *
*							 A G O T			    *
* Menneske. 4 point		Spillet kort: kloer 5       *
*							VUNDET					*
*****************************************************
Tryk Enter for at forts�tte.

Start programmet i VisualStudio.
tryk p� enter for at komme videre
Hvis du vil spille igen efter endt spil
	tryk j [ENTER]

Der er bem�rkninger i koden i alle klasser.

Program.
Indgang til spillet. Har et gameloop som styrer opstart slut af spil, samt skaber de 2 spillere som bruges i Control.

View.
Indeholder en Renderer som bruges af Control til at vise resultatet af genneml�bet af spillogikken.
View har ingen logik andet end hvad der skal til for at skabe et view af sendte data med den rette formattering, samt skrive det view p� sk�rmen.

Control.
Bruger View, Model og DAL(Data Access Layer). Styrer logikken under spil, s�rger for at kalde de rette views, opdaterer data strukturen.

DataAccessLayer.
I dette tilf�lde er der metoder til at skabe datagrundlaget for spillet, hvilket ikke er normalt for et DAL. Den mere traditionelle funktionalitet 
er ogs� tilstede. Henter/manipulerer med data.

Data.
Initialiseres af DAL, indeholder metoder til at skabe et kortspil og dele dem ud p� 2 bunker.

Model.
Indeholder de datab�rende klasser der ligger til grund for spillet. Alle klasser har private variable som manipuleres via properties. Dette for at
beskytte data. I de gettere og settere der er lavet kan der laves logik, som evt. beskytter data, eller data validitet.

Enums.
Indeholder de mulige v�rdier for et kort eks. Spar eller Konge som kul�r og navn/v�rdi. Da det er enums kan disse bruges i numeriske operationer.

Testprojekt.
Der er tilknyttet et test projekt som kan benytte klasserne og deres properties i projektet, selvom de er defineret som internal.
Man kunne lave flere tests, men jeg har lavet test p�
	Der ikke er to kort som er ens i de to spiller bunker
	At det virker at tr�kke kort, og at man kan nedskrive antal runder.
	At antal runder bliver sat som forventet.

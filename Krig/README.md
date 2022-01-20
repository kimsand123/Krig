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
Tryk Enter for at fortsætte.

Start programmet i VisualStudio.
tryk på enter for at komme videre
Hvis du vil spille igen efter endt spil
	tryk j [ENTER]

Der er bemærkninger i koden i alle klasser.

Program.
Indgang til spillet. Har et gameloop som styrer opstart slut af spil, samt skaber de 2 spillere som bruges i Control.

View.
Indeholder en Renderer som bruges af Control til at vise resultatet af gennemløbet af spillogikken.
View har ingen logik andet end hvad der skal til for at skabe et view af sendte data med den rette formattering, samt skrive det view på skærmen.

Control.
Bruger View, Model og DAL(Data Access Layer). Styrer logikken under spil, sørger for at kalde de rette views, opdaterer data strukturen.

DataAccessLayer.
I dette tilfælde er der metoder til at skabe datagrundlaget for spillet, hvilket ikke er normalt for et DAL. Den mere traditionelle funktionalitet 
er også tilstede. Henter/manipulerer med data.

Data.
Initialiseres af DAL, indeholder metoder til at skabe et kortspil og dele dem ud på 2 bunker.

Model.
Indeholder de databærende klasser der ligger til grund for spillet. Alle klasser har private variable som manipuleres via properties. Dette for at
beskytte data. I de gettere og settere der er lavet kan der laves logik, som evt. beskytter data, eller data validitet.

Enums.
Indeholder de mulige værdier for et kort eks. Spar eller Konge som kulør og navn/værdi. Da det er enums kan disse bruges i numeriske operationer.

Testprojekt.
Der er tilknyttet et test projekt som kan benytte klasserne og deres properties i projektet, selvom de er defineret som internal.
Man kunne lave flere tests, men jeg har lavet test på
	Der ikke er to kort som er ens i de to spiller bunker
	At det virker at trække kort, og at man kan nedskrive antal runder.
	At antal runder bliver sat som forventet.

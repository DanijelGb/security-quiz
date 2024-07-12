



using System;
using System.Reflection;

string dhcp = @"
DHCP(Dynamic Host Configuration Protocol) är ett nätverks distribitions protokoll som automatiskt 
ger ut nya ip adresser på ett dynamiskt sätt. Dessa ip adresser inkludera Subnet Mask, Default 
Gateway DNS-Servers och mera. DHCP leasar IP adresser till en enhet till en begränsad mängd tid.
När denna tid går ut så måste enheten få en ny lease och ett nytt tillgängligt IP ifrån DHCP.
funktionen blir att en ip adress inte går försvunnen hos en oanvänd enhet och på så sätt så
finns det inte lika många IP adresser att välja mellan.

DHCP används både i små och stora nätverk
och underlättar väldigt mycket för den administrativa bördan av utdelning av IP adresser.";


string mac = @"
En MAC(Media Access Control) adress är den UNIKA adressen som en enhet har. En MAC adress kan aldrig
dupliceras och förblir alltid unik. Detta är viktigt för routrar och switchar att känna till vilka
enheter de ska ge viss tillgång till. MAC adresser har alltid detta format: 00:1A:2B:3C:4D:5E. Första
halvan identifierar vem som har skapat enheten medan sista halvan ger den den unika aspekten.";

string ipAdr = @"
En IP adress tilldelas av din router. Du har en IP adress lokalt som brukar se ut som 192.168.1.1.
Din IP adress kommer se annorlunda ut när du är ute på webben. Det finns för närvarandra två typer
av aktiva IP adresser. Den första är IPv4 som består av 4 octetter.";

string port = @"
En port är en logisk kanal var data kan överföras mellan enheter i ett nätverk. Varje port är associerad
med en specifik protokolltyp och en särskild tjänst eller applikation. När data skickas behövs ett port-nummer
för att datan ska dirigeras till rätt plats. De vanligaste portarna är standardiserade av IANA(Internet
Assigned Numbers Authority) och används för kända tjänster och protokoll. Port 80 = HTTP. Portar används
lokal nätverk (LAN) såväl som över internet.";

string nat = @"
NAT(Network Address Translation) är en teknik som finns i din router. NAT tilldelar varje enhet inom ditt 
nätverk en privat IP. Sedan konverterar NAT enhetens privata ID till nätverkets gemensamma offentliga IP.  
Denna funktion tillåter ditt nätverk att operera under en enda offentlig IP adress men flera stycken privata.
Detta sparar på pengar och framförallt på IPv4 adresser som totalt sett finns 4 biljoner av.";

string dns = @"
DNS(Domain Name System) server är skapad för att människor kan lättare urskilja namn ifrån varandra än de 
kan siffror. DNS servern matchar domännanet som du angett med en IP adress som då leder dig till önskad
sida. Hur det funkar - Du skriver in ett domännamn i din webbläsare, om inte webbläsarens cache minne hittar
domännamnet, då skickas förfrågan till Resolver Servern som kommer kolla SITT cache minne. Om den inte har 
domännamnet sparat så skickas förfrågan till Root Servern. Det finns 13 st av dessa runtom världen,
strategiskt placerade. Root Servern vet inte vilken IP användaren ska ha men den vet var den ska skicka den
vidare, nämligen till TLD(Top Level Domain) som inte heller vet vad IPn är men baserat på att hemsidan
slutar på .com så kan den skicka den till nästa och sista leveln Authoritative Name Server som har hand
om dessa nätverken som slutar på .com. Äntligen får Resolver Servern sin IP adress och kommer nu att
spara denna IP adressen i sin cache så att den slipper göra om hela processen igen för denna IPn.
";

string segmentering = @"
Segmentering av nät betyder att man delar upp ett nätverk till flera seperata nätverk. Detta kan man
göra genom att använda flera switchar/routrar eller så kan man göra det på samma switch/router med flera
VLAN(Virtual Local Area Network). Detta gör alla nätverken simplare, det lättar på hårdvaran av 
routrar/switchar och dessutom gör det totala nätverket mer säkert.";

string vlan = @"
VLAN(Virtual Local Are Network) gör det möjligt att segmentera ett nätverk. Detta görs genom att man
ställer in portar på en switch/router. Man kan tillexempel ställa in 3 portar för ett visst VLAN och
sedan ställa in 4 andra portar till ett annat VLAN. Dessa kan alla fungera samtidigt och isolerat från
varandra. Detta minskar säkerhets risken genom att om man hackar in sig i en av VLAN så har man fortfarande
inte åtkomst till resten av VLANsen.";

string tcp = @"
TCP(Transmission Control Protocol) är ett protokoll som överför data från en dator till en annan över
internet. TCP är pålitlig och är ett anslutningsorienterat protokoll, vilket innebär att datan som
levereras gör så ordentligt och i rätt ordning. Protokollet använder sig av en 3 Way Handshake som
verifierar att båda parter har fått korrekt information";

string threeWayHS = @"
Detta sker genom TCP. Det börjar med att klienten skickar en SYN till värden *Hejsan server, kan
du öppna upp en koppling?* Värden skickar en ACK som bekräftar klientens och skickar en egen SYN
för att klienten ska bekräfta att denne också har fått meddelandet. Det gör klienten genom att skicka
över en sista ACK. Nu kan båda parterna skicka meddelande till varandra.";

string udp = @"
UDP(User Diagram Protocol) är liknande till TCP på sättet att det är ett protokoll som skickar data. UDP garanterar
dock inte att datan kommer fram, den är sessionless (Fire and Forget) vilket gör den snabbare
än TCP och mer användbar i situationer var det prioriteras.";

string hash = @"
En hash är en string av bokstäver och tecken som representerar en annan text. Det är typ som en
kryptering förutom att man kan aldrig dekryptera en hash. Det är en one way street. En hash är 
alltid lika lång oavsett datan den representerar/skyddar. Det finns flera hashnings metoder dock
som har olika längder. Det kan aldrig finnas två likadana hash om inte dem representerar exakt 
samma text. Man hashar oftast lösenord.";

string åttahundraettx = @"
802.1X är en standard som finns på routrar och switchar till exempel. Standardens jobb är
att autentisiera en användare som vill ansluta till nätverket. Närverksenheten kommer sen att
skicka en förfrågan till en RADIUS-server för att hämta uppgifter om denna användare. Användaren
kommer att bli tilldelat den åtkomsten som RADIUS-servern har berättat för nätverksenheten.";

string https = @"
HTTPS(Secure Hypertext Transfer Protocol) är den säkra versionen av HTTP. Skillnaden är att
HTTPS använder sig av TLS(uppdaterade versionen av SSL) som kollar en hemsidas certifikat
innan den ansluter till den. Om certifikatet finns så räknas hemsidan som säker annars
betraktas den som osäker. De flesta hemsidorna har TLS även om det inte gäller känslig
data, detta är pga google flaggar hemsidor som inte har certifikat och då hamnar de
långt bak i sökmotorn.";

string captiveportal = @"
En Captive Portal är en portal som du behöver på något vis autentisiera dig själv. Ett
exempel på detta är till exempel flygplatsen. När man försöker ansluta till Kastrups
wifi så kommer det upp en captive portal var man behöver fylla i viss information för att
få använda deras wifi.";

string wifiSäkerhet = @"
WEP(Wired Equivalent Privacy) - Första säkerhets protokollet som skapades 1999. Har endast
40 bit kryptering och därför hackas enkelt. Används inte mera.

WPA(WiFi Protected Access) - Uppgraderad version av WEP som använder sig av TKIP(Temporal 
Key Integrity Protocol) som dynamiskt uppdaterar krypteringen och gör det svårare att hacka.

WPA2 - Använder AES(Advanced Encryption Standard) istället för TKIP. Detta är en säker metod
för att kryptera data, den förhindrar brute force attacker med mera genom symmetrisk
kryptering. USAs regering använder det.

WPA3 - Är ny och inte så vanlig ännu. Den har nya funktioner som förenklar wifi säkerhet
och säkrar autentiseringen ännu mer. Den försvårar också gissningar av lösenord. Den är
allt som allt en generellt bättre version.

WPS(Wifi Protected Setup) - Detta är en simplifierad version som är ämnad för otekniska användare.
Man behöver inget lösenord för att ansluta genom detta protokollet. Det finns en knapp på både
routern och enheten man vill ansluta till routern. Man trycker på båda knappar så borde man vara
ansluten inom 2 minuter. Man kan också välja alternativet att man skriver in ett PIN-nummer
istället för att trycka på knappen.";

string symmetriskKryptering = @"
Symmetrisk Kryptering är en krypterings metod där två parter kommer överrens om vad nyckeln
för kryptering och dekryptering är. Det farliga i detta är hur nyckeln överförs till den andra.
Man kan ge nyckeln genom en fysisk USB och detta vore det absolut säkraste. Man kan även skicka
den över internet som medför en viss risk av läckage till obehörig hackare.";

string osymmetriskKryptering = @"
Osymmetrisk Kryptering är en krypterings metod där det finns en public key och en private key.
Båda parterna skickar sin public key till varandra som då kan snos av en hackare, detta spelar
ingen roll dock för att de kommer aldrig skicka sin private key. Det är med hjälp av sin egna
private key och den andras public key som på något sätt de kommer till en gemensam key som
de kan använda för krypteringen. Denna key kan hackaren aldrig komma fram till.";

string brandväggsTyper = @"
Skydd mot obehörig åtkomst. Kontroll av inkommande och utgående trafik. Blockering av skadlig
kod och malware. Hantering av nätverkssäkerhet och dataintegritet.

Nätverksbrandvägg - Detta är en brandvägg som reglerar vilken typ av trafik som får passera
från allmäna internet till ditt interna nätverk. IP-adresser, portar, protokoll och andra attribut.

Programvarubrandvägg - Det är en brandvägg som finns på enskild dator eller enhet för att skydda.

Proxybrandvägg - VPN. Den skapar en skyddad tunnel mellan interna användare och externa resurser.
";

string states = @"
Stateful kommunikation innebär att information sparas. Det betyder att man har en session. 
TCP (Transmission Control Protocol) är en stateful kommunikationsprotokoll som behåller 
sessionstillstånd för att säkerställa pålitlig dataöverföring.

Stateless kommunikation innebär motsatsen och sparas inte men är nytt varje gång man
ansluter.
UDP och HTTP är exempel på kommunikations protokoll som inte skapar en session och
håller koll på föregående data.

När det gäller brandväggar så är stateful ett mer precist och analytiskt verktyg.";

string dpi = @"
DPI(Deep Pocket Inspektion) är en avancerad teknik som kan användas i högt säkra brandväggar.
Den kräver mer resurser som till exempel processorkraft, minne. Den går igenom precis vartenda
paket som tas emot, granskar den och baserat på inställningar så släpper den förbi trafiken.
Den kan se ifall en hackare försöker maskera malicious data i en port. Den tar en djupare blick
än stateful till exempel.";

string brandväggSandb = @"
Vissa dyrare brandväggar har en inbygg sandbox funktion som tillåter brandväggen att faktiskt
testa vissa paket som DPIn har dömt som misstänksamma. Inom denna sandbox miljön så kan inte
virus och annat spridas utanför den isolerade miljön, vilket gör det till en säker plats att
testa okända paket.";

string scadaSystem = @"
Ett SCADA-system (Supervisory Control and Data Acquisition) är en typ av övervaknings- och
styrningssystem som används inom industriella och infrastrukturella miljöer för att övervaka
och styra processer och anläggningar i realtid. Det tillåter användare att samla in data från
sensorer och enheter, visa informationen på ett användargränssnitt och fjärrstyra processer för
att optimera drift och prestanda.";

string dmz = @"
DMZ(Demilitarized Zone) är ett läge mellan internet och det interna nätverket. Det finns på grund
av säkerhetsskäl. Det blir som ett gästnätverk, du har åtkomst till en ytlig del av nätverket.
Du kan alltså använda vissa utvalda funktioner i nätverket men kan fortfarande inte komma åt
resterande nätverk.";

string protocols = @"
Lista av internet protokoll.
- ARP (Address Resolution Protocol) RFC826
        - Resolves IP to MAC mappings
     	- ARP requests / ARP Responses
- FTP (File Transfer Protocol
- SMTP (Simple Mail Transfer Protocol)
        - Används inte längre pga gammal och dålig kryptering
- HTTP (Hypertext Transfer Protocol)
- TLS (Transport Layer Security) Används i HTTPS
        - Nyare och bättre kryptering än SSL.
- HTTPS (Secure Hypertext Transfer Protocol)
        - Säker version av HTTP som använder sig av SSL och TLS
";

string ipTypes = @"   
För att ansluta till internet och få *internet connectivity* så krävs det att du har blivit
tilldelad av din DHCP eller att du har sedan innan dessa fyra IPs.
- IP 9.1.1.11 - Hosts Identity on the internet
- Subnetmask {/ 24 OR 255.2555.255.0}  - Size of Hosts network
- Default Gateway {9.1.1.1} - Routers IP Adress
- DNS Server IP(s)  {8.8.8.8} - Translate domain names to IPs";

string hub = @"
En hub är den mest primitiva nätverksenheten som sköter anslutningar. Den opererar med en
halv duplex som betyder att en signal kan endast skicka åt ett håll i taget. Alltså när du
gör en broadcast så skickar den ut broadcasten till en server och den måste vänta tills den
har nått fram till servern tills den kan få en signal tillbaka. Den kommer även skicka all 
data till alla anslutna enheter och då får varje enhet som inte skulle få meddelandet att
avfärda det meddelandet. Den kan alltså inte memorera vem som är vem, olikt en switch
eller router. Detta gör den rätt långsam och ineffektiv i jämförelse med switch och router.";

string switchh = @"
En switch är en bättre version av en hub. Dock är switchen inte heller så smart eller
kanske analytisk är bättre ord. Den kan dock minnas vilken MAC adress som tillhör vilken
server och på så sätt behöver endast göra en broadcast en gång per session.
Switchar används flitigt, dem är snabba, kostnadseffektiva och gör ett bra jobb.";

string router = @"
En router är en mycket mer avancerad version av switch. Det finns mycket avancerade routers
till standard routers som finns i de flera personhemmen. Routers har många funktioner, bland
annat DHCP funktion. En router har mycket bättre koll på vilka enheter den har i sitt nätverk.
Routrar kan ha sina egna brandväggar och allt möjligt.";

string proxy = @"
En proxy server används ofta av företag, skolmiljöer eller liknande. 
- Skydd. Den avslöjar aldrig din IP men använder sin egna IP och därmed skyddar dig från attacker.
- Bredband. Den kan ha vanligt förekommande hemsidor cachade(sparade) vilket gör dina sökningar
snabbare och även sparar på bredband.
- Logg. En proxy loggar aktivitet som sker på/genom proxyn servern.
- Reglering. Admin ställer oftast in vad för typ av trafik man har åtkomst till.";

string trunk = @"
";

string ips = @"
IPS(Intrusion Protection System) skyddar ditt nätverk. Den har samma funktioner som IDS, vilket
innebär att den kan se mönster, jämföra med kända hot etc. Skillnaden på dessa två är att IPS
kommer aktivt ta säkerhetsåtgärder. Det kan vara signaturbaserad blockering, anomalibaserad
blockering och hantering av tillåtna trafikflöden med hjälp av regler och policyer.";

string ids = @"
IDS(Intrusion Detection System) skyddar ditt nätverk. Den gör så genom att den övervakar nätverks
trafiken. Den är bra för att den kan se mönster och kombinationer av aktiviteter som tillsammans
är misstänksamma. Den kan även använda sig av signaturbaserad detektion vilket innebär att den
har tillgång till kända hot och kan jämföra de med det som händer i den lokala nätverkstrafiken.
När IDS har upptäckt ett hot så kommer den att börja larma för att notifiera om detta.";

string promiscious = @"
";

Dictionary<string, string> quiz = new Dictionary<string, string>
{
    { "Beskriv vad IPS är", ips },
    { "Beskriv vad IDS är", ids},
    { "Beskriv vad DNS är", dns},
    { "Beskriv vad DHCP är", dhcp},
    { "Beskriv vad en router är", router},
    { "Beskriv vad en MAC address är", mac},
    { "Beskriv vad en IP address är", ipAdr},
    { "Beskriv vad en port är relaterat till en nätverksenhet", port},
    { "Beskriv vad NAT är", nat},
    { "Beskriv vad VLAN är", vlan},
    { "Beskriv vad TCP ", tcp},
    { "Berätta vad Three Way Handshake är", threeWayHS},
    { "Berätta vad UDP är", udp},
    { "Berätta vad en hash är", hash},
    { "Berätta vad 802.1X är", åttahundraettx},
    { "Berätta vad HTTPS är", https},
    { "Berätta vad en Captive Portal är", captiveportal},
    { "Berätta vilka typer av Wifi-säkerhet det finns och skriv lite om vad de gör", wifiSäkerhet},
    { "Berätta vad symmetrisk Kryptering är", symmetriskKryptering},
    { "Berätta vad osymmetrisk Kryptering är", osymmetriskKryptering},
    { "Berätta vilka brandväggstyper som finns och skriv lite om dem", brandväggsTyper},
    { "Berätta vad stateful och stateless innebär", states},
    { "Berätta vad DPI är", dpi},
    { "Berätta vad ett SCADA system är", scadaSystem},
    { "Berätta vad DMZ är", dmz},
    { "Berätta vilka internet protokoll som finns och lite om vad de gör", protocols},
    { "Berätta vilka IP typer ett nätverk har och lite kort om vad de gör", ipTypes},
    { "Berätta vad en hub är", hub},
    { "Berätta vad switch är", switchh},
    { "Berätta vad en proxy server är", proxy},
    { "Berätta vad en sandbox i en brandvägg är", brandväggSandb},
    { "Berätta vad segmentering är och vad som är bra med det", segmentering},

};

System.Random random = new();
//31

while (quiz.Count != 0)
{
    int roll = random.Next(1, quiz.Count);
    string question = quiz.Keys.ElementAt(roll);
    string answer = quiz[question];

    Console.WriteLine("Question: " + question);

    string? input = Console.ReadLine();

    Console.WriteLine("Answer: " + answer);
    Console.ReadKey();

    quiz.Remove(question);
    Console.Clear();
}



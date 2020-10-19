# PostRequestSender
Jelen mappa tartalma egy nagyobb körű projekt osztályaként szolgált, ami sajnálatos módon nem elérhető.
Célja egy olyan osztály létrehozása, amely által http post requesteket küldhetünk adott web servernek a PostRequestString osztály által, amelyet az olvasó megtalálhat a PostRequestString.cs fájlban.
A hozzáírt Windows Form csupán a tesztelést szolgálta.

## A http protokoll, a http request, a post request, és a request handler definiálása
A PostRequestString osztály értelmezéséhez célszerű röviden szót ejteni a http protokollról, a http request-ekről, kiváltképp a post request-ről, továbbá a request handler fogalmáról.

#### Http
A Hyper Text Transfer Protocol egy információátviteli protokoll, amely szerverek és kliensek között teszi lehetővé a kommunikációt.
A kliens - ez legtöbbször egy egyszerű böngésző, de a mi esetünkben, ez a mi asztali szoftverünk – elküld egy HTTP request-et a szervernek, amelynek következtében a szerver visszaküldi a maga válaszát. Ezek a válaszok a lekérések állapotáról szóló adatok, illetve a szerverről lehívott tartalmak lehetnek.

#### Http request
Az imént definiált HTTP requesteket a HTTP metódusok által tudjuk érvényesíteni, s ezek a következők: GET, POST, PUT, HEAD, DELETE, PATCH, OPTIONS. Számunkra, ami fontos, az a POST request.

#### Post request
POST request segítségével tudunk a kliens oldaláról adatot szolgáltatni a servernek. Tehát a legáltalánosabb GET request-tel ellentétben nemcsak adatot hívunk le, hanem ellenkezőleg, adatot töltünk fel.
#### Request handler
Nem elég a kliens oldaláról egy POST request-tel elküldeni a kívánt adatokat a servernek, hanem annak a servernek tudnia kell mit kezdeni a beérkező adattal. Mindezt csak úgy tudja megtenni, ha rendelkezik egy request handler funkciót ellátó weboldallal, adott server oldali programnyelven kódolva.
A mi esetünkben a frontend küld egy post request-et a mikrovezérlőre telepített webserverre, ami e beküldött kérést lekezeli, és továbbítja azt a vezérlésre.

### A System.Net.HttpWebRequest osztály bemutatása
Legyen szó előbb a System.Net.WebRequest osztályról, amely által tudunk adott request-et küldeni adott URI-nak. A System.Net.HttpWebRequest ennek az előbbinek egy HTTP specifikus implementációja.
 
Leszármazása: Object &rarr; MarshalByRefObject &rarr; WebRequest &rarr; HttpWebRequest

### A PostRequestString osztály bemutatása
A PostRequsetString osztály egy fontos metódussal rendelkezik, a PostRequest metódussal, ami rendelkezik egy url nevű string, és egy inputString nevű, szintén string paraméterrel. Amint ezen változók neveiből és magától értetődik, az url tárolja el azt a címet, amelyre küldjük a POST requestet, az inputString pedig azt a string változót, amit küldeni szeretnénk a webservernek. Tulajdonképpen ez az a string változó, ami tárolja, és elviszi drónunk közlekedéséhez szükséges irányítási parancsot.
A metódus statikus, tehát hívásához nem szükséges példányosítani a PostRequestString osztályt. Visszatérítési értéke az a stringgé konvertált üzenet, amit a webservertől kapunk vissza.

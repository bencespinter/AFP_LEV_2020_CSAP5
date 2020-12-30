# Rendszerterv

## A rendszer célja
A rendszer célja a folyamatosan újuló igények kielégítése valamint a játékok izgalmasságának fenntartása. A játékos választhat pályát, melyek egyre nehezednek, váratlan események történhetnek, így ha végig akarják játszani a játékot akkor fejleszteniük kell a reakcióidejüket valamint a memóriájukat(pl egy hosszúpályánál), megoldóképességüket. A játékos az idő és a begyűjtött kincsek függvényében pontszámot kap. Minél rövidebb idő alatt végez a pályán és minél több kincset gyűjt be, annál magasabb pontszámot ér el. A pontszámokból kap visszajelzést a teljesítményéről. Fontosnak tartottuk azt is, hogy a felhasználók könnyen el tudjanak igazodni a felületeken, ezért egyszerű menüt készítünk. Célunk az is, hogy Androidos eszközökön, valamint webes felületen is elérhető legyen.

## Projektterv
**Résztvevők és főbb szerepköreik:**
**Pintér Bence:** Scrum master
**Csathó Zsolt:** Product owner
**Kis Szandra:** Team member
**Pamlényi Artúr:** Team member

## Üzleti folyamatok modellje
A felhasználó az első indításkor meg kell addnia a játékos nevét ha van ilyen név már mentve akkor betölti az eddigi eredményeket ha nincs akkor létre lesz hozzva neki egy új mentés . Mentés betöltése után egy egyszerű menüt láthatunk majd ahol ki lehet választani a pályákat , be lehet a zene hang erejét állítani és ki lehet lépni.

## Követelmények
**Funkcionális követelmények:**
	- Felhasználó nevének tárolása
	- Felhasználó pontszámának tárolása
	- Felhasználó idejének tárolása
	- Felhasználó in-game progress-ének tárolása
	- Főmenü kezelhetősége
	- Toplista
	- Időszámláló

**Nem funkcionális követelmények:**
	- Letisztult, felhasználóbarát felület
	- Betöltés és mentés gyors működése
	- Optimalizáltság

**Törvényi előírások, szabványok:**
	- GDPR-nak való megfelelés
	- Általános információk
	- Szellemi tulajdon
	- Használat
	- Felelősségi szabályok
	- Technikai követelmények
	- Garancia és kártérítés
	- 2013. évi V. törvény
	- Európai Parlament és Tanács 2016. április 27-i (EU) 2016/679 Rendelete
	- 2011. évi CXII. törvény
	- a szerzői jogról szóló 1999. évi LXXVI. törvény
	- 2001. évi CVIII. törvény

## Architekturális terv
Az asztali program Unity keretrendszer használatával készül el. Bejelentkezés után elérhetőek lesznek az eddig elért eredmények.  

## Implementációs terv
### Windows Desktop Application  
Az alkalmazás felhasználói oldalát asztali alkalmazásnak tervezzük. A terv a C#  nyelv használatát írja elő, főleg mert ismerős és könnyen használható.

## Funkcionális terv
**Rendszerszereplők:**
Felhasználók

**Rendszerhasználati esetek és lefutásaik:**
Felhasználók:
- Név megadása ami betölti az előzményeket, ha voltak, ha nem akkor új felhasználót hoz létre
- Karakter kiválasztása
- Pálya kiválasztása
- Következő pályára lépés 
- Pálya újrakezdése
- Zene lenémítása
- Zene felhangosítása
- Toplista megtekintése
- Kilépés

**Menü-hierarchiák:**
MAIN MENÜ
- Játék
- Toplista megjelenítése
- Hangerő beállítása

JÁTÉK
- Név megadása
- Karakter kiválasztása
- Pálya kiválasztása

## Fizikai környezet
- Az alkalmazás PC-re készül
- A következő operációs rendszereken lesz elérhető: **Windows, Linux, Macintosh**
- Nincsenek megvásárolt komponenseink
- Nincsenek alkalmazáson belüli mikrotranzakciók
**Fejlesztői eszközök:**
- Unity
- Visual Studio

## Absztrakt domain modell
A rendszert a felhasználó egy Windowsos alkalmazáson keresztül érheti majd el, aminek az elkészítését C# nyelven tervezzük. A felület lehetővé teszi majd a felhasználó számára a név megadásával a bejelentkezést. Későbbiekben ehhez a névhez rendeljük a felhasználó pontjait amit megjelenítünk egy táblázatban a többi felhasználó nevével és pontjával. A felhasználó választhat a karakterek közül, illetve pályák közül. Akkor léphet a következő pályára, ha az azt megelőzőt végigjátszotta, azaz legalább 1 csillagot szerzett. Csillagot a pálya teljesítése alapján kap a pálya végigjárása és a pálya hossza arányában. A hangerősséget lehet majd állítani illetve lenémítani.

## Teszt terv
A tesztelések célja a rendszer és komponensei funkcionalitásának teljes vizsgálata, ellenőrzése, a rendszer által megvalósított üzleti szolgáltatások verifikálása.

**Tesztelési eljárások**
- Unit teszt: A teszt elsődleges célja: az eddig meglévő funkcióknak a különböző böngészőkkel való kompatibilitásának tesztelése. A tesztet a fejlesztők végzik. 
Az eljárás sikeres, ha különböző operációs rendszereken megfelelően működnek a különböző funkciók. A teszt időtartama egy hét.

- Beta teszt: Ezt a tesztet nem a fejlesztők végzik.
Tesztelendő operációs rendszerek: Windows , Linux , MacOs
Tesztelendő kijelző méretek: 1280x720 (minimum), 1366x768, 1920x1080
A teszt időtartama egy hét. 
A tesztelés alatt a tesztelő felhasználók visszajelzéseket küldhetnek a fejlesztőknek, probléma/hiba felmerülése esetén. 
Ha hiba lép fel, a fejlesztők kijavítják a lehető leghamarabb. Sok hiba esetén a tesztelés ideje elhúzódhat plusz egy héttel.

- Tesztelendő funkciók, Backend Service: Képesnek kell lennie menteni a játékos adatait és azokat betölteni  
Képesnek kell lennie minden felületen elérhető funkciók biztosítására.

## Telepítési terv
A Játékos a web oldalunkat felkeresve a letöltheti. Itt kettő változat közül választhat egy pocket editon közül mely telepítés nélkül működik és rögtön játszható. Teleíthető váltazat varászló segítségével ez a változat végig vezeti a felhasználót a telepítés menetén kényelmesen , meg szokott módon és minden hiányzó programot , .dll telepít. Sikeres telepítés után a játék már rögtön játszható és élvezhető. 

## Karbantartási terv
Az alkalmazás folyamatos üzemeltetése és karbantartása, mely magában foglalja a programhibák elhárítását, a belső igények változása miatti módosításokat, valamint a környezeti feltételek változása miatt megfogalmazott program-, illetve állomány módosítási igényeket. Ellenőrizni kell, hogy a jövőben kiadott Microsoft Windows verziókkal kompatibilis-e az alkalmazás. A jövőben szükség lehet új hardware implementációra igénynövekedés esetén. Karbantartás Corrective Maintenance: A felhasználók által felfedezett és "user reportban" elküldött hibák kijavítása. Adaptive Maintenance: A program naprakészen tartása és finomhangolása. Perfective Maintenance: A szoftver hosszútávú használata érdekében végzett módosítások, új funkciók, a szoftver teljesítményének és működési megbízhatóságának javítása. Preventive Maintenance: Olyan problémák elhárítása, amelyek még nem tűnnek fontosnak, de később komoly problémákat okozhatnak.


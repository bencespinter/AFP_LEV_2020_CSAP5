# Teszt jegyzőkönyv

### Main Project

|  Dokumentum címe: (azonosítója) |  [2D_Game_Project_T5](https://github.com/bencespinter/AFP_LEV_2020_CSAP5/tree/main/2D_Game_Project_T5 "2D_Game_Project_T5") |
|---|:-:|
| **Minősítés: (állapot)**  |  Jóváhagyott |
| **Verziószám:**  |  ALFA 0.1 |
| **Projekt név:** |  2D_Game_Project |
| **Készítette:** | team5 |
| **Utolsó mentés kelte:** | 2020.12.23 |
| **Dokumentum célja:** | A projekt aktualis állapotának bemutatása   |
| **Fájlnév** | test.md |

### Projektben résztvevő fejlesztők:

|  Név | Szerepkör |
|---|:-:|
| Pintér Bence | Scrum master |
| Csathó Zsolt | Product owner |
| Kis Szandra | Team member |
| Pamlényi Artúr|  Team member |

## 1. Bevezetés
Tesztelés célja a projektben megtalálható funkcionális és design hibák feltárása.

### 1.1 Tesztelési terv hatóköre, célja:

- A tesztelési terv célja a tesztelés teljes körűségének biztosítása, a tesztelés során alkalmazott eljárások és megoldások meghatározásával.
- A teszt végrehajtásáért ez esetben a test manager fele , és a tesztekést azt általa összeállított tesztcsapat hajtja végre a 2.1. fejezetben meghatározott módon.

### 1.2 Elvárások
#### Az alábbi alap elvárások képezik ennek a teszttervnek az alapját:
- Az olvasó ismeri az alapdokumentumokat, amelyek meghatározzák a rendszert. 
- Az **team5** projektcsapat felelős a tesztadatok előállításáért.

## 2 Szükséges erőforrások
- Windows alapú rendszer
- src mappa csatolása

### 2.1 Feladatkörök és felelősségek (tesztcsapat meghatározása)
| Feladatkör  |  Felelősség/tevékenység |  Személy  |
|---|---|---|
|  **Tesztelő, Teszt-koordinátor:** |  A teszt végrehajtása, észrevételek dokumentálása, teszt dokumentáció archiválása.Teszt terv készítése.  A tesztterv jóváhagyatása a projektmenedzserrel.  Teszt forgatókönyvek létrehozása  Inkonzisztenciák kezelése.  Helyes és időbeni hibakezelés.  Szükség esetén problémák eszkalálása a projekt menedzsernek.  Végső riport készítése.  Teszt dokumentum archiválása.  Az észrevételek státuszának követése, ill. dokumentálása | név  |
| **Szakértő:**  |  A szakértő az észrevételek elemzi és megoldást javasol. | név |
|**Projektvezető:**| Teszt terv jóváhagyása  Teszt forgatókönyv (testscript)| név |

### 2.2 Tesztkörnyezet
| Környezet neve és feladata  |  A hozzáférés módja | Konfiguráció  |
|---|---|---|
| Unity | Offline - Szabad szoftver | Windows 10 - alapértemezett beállítások |
| Visual Studio  | Offline - Szabad szoftver | Windows 10 - alapértemezett beállítások |

### 2.3 Tesztadatok
A teszt végrehajtásához szükséges rekordok (tesztadatok) száma: 3
A tesztadatok elkészítéséért és feltöltéséért felelős személy: Pintér Bence


### 2.4 Leszállítandó teszt dokumentumok
Az összes teszt dokumentáció és leszállítandó a következő helyen érhető el: [LINK](https://github.com/bencespinter/AFP_LEV_2020_CSAP5)

| Cím  |  Felelős személy | Szállítási gyakorisága  | Szállítás módja |
|---|---|---|---|
|  **GUI teszt - IDL** |  név |  Egyszeri |  github repository |


### 2.5 Tesztelési eszközök
- Unity *Fejlesztői környezet* [LINK](https://unity.com/)
- Visual Studio *Fejlesztői környezet* [LINK](https://visualstudio.microsoft.com/)

## 3 Tesztelési terv
Fejezeteket teszteltünk, csakis akkor töltöttük fel a programkódot ha az megfelelt az elvárt követelményeknek, és a lehető legkevesebb bugot tartalmazta/nem is tartalmazott.
**Tesztelés lépcsői:**
- Graphics and BufferStrategies
- Handler
- Movement, collision, jumping
- Sprites and SpriteSheets
- Animation
- Camera
- Level design
- Powerup, Enemies, Coins, Mini Boss

### 3.1 Fejlesztői teszt
A fejlesztői tesztelés célja a rendszer alapvető funkcióinak ellenőrzése, a hibakezelés és az alapvető funkciók működésének vizsgálata


### 3.2 Prototípus (modul) teszt
A prototípustesztelés (vagy másik nevén modultesztelés) célja a rendszer már működő moduljainak önálló tesztelése, a modulon belüli hibák azonosításának és kiküszöbölésének érdekében. 
**Módszere:** 
A szegmensek validálása egyénileg történik. A tesztelés visszont a szegmensek föggőségeire is ki terjed.

### 3.3 Integrációs teszt
Az integrációs teszt célja a rendszer más rendszerekhez történő illesztésének vizsgálata, a több rendszereken keresztül átívelő funkciók tesztelésének érdekében. Az adatmigrációs tesztelés az integrációs teszteléshez tartozik, ennek lényege, hogy a bevezetendő rendszerbe áttöltik azokat az adatokat, amelyekkel a rendszer dolgozni fog és letesztelik a betöltött adatok, illetve az adatokat kezelő funkciók helyességét. 


### 3.4 Elfogadási teszt
Az elfogadási teszt (angolul User Acceptance Test) célja a rendszer teljes funkcionalitásának vizsgálata a felhasználók szemszögéből
**Módszere:**
A teszt egy kontrol csoportal zajlik, egy külső cégen keresztül.

### 3.5 Terheléses teszt
A terheléses teszt célja a tervezett kapacitások, valamint a rendelkezésre álló növekedési potenciál meghatározása.
**Módszere:**
A próba telepítést követően egy meghívott teszt közönéggel zajlik, szimulálva egy átlagos napi használatot.

### 3.6 Biztonsági teszt (audit):
Biztonsági tesztelésre akkor van szükség, ha a rendszer szenzitív (pl. személyes vagy pénzügyi) adatokat kezel, vagy szabadon elérhető az internetről. 
**Módszere:**
A tesztett egy megbízott külső cég végzi.

### 3.7 Go live teszt
A go-live teszt egy próbaélesítés, melynek során a korábbi rendszerek továbbra is üzemelnek annak érdekében, hogy az élesítéskor keletkező problémák ne befolyásolják a normál üzemi működést.
**Módszere:**
A próba telepítés a megrendelő által választott webtárhelyen történik, a programot a jövőben üzemeltető adminisztrátorok közreműködésével.

### 3.8 Tesztelési feladatok, teszt-esetek leírása
A tesztelési feladat a következő teszt-eseteket foglalja magában:
- Fejlesztői teszt
- Prototípus (modul)

## 4 Tesztelési ütemterv, függőségek – tesztforgatókönyv
### 4.1 Tesztelési jegyzőkönyv
A tesztelők a tesztforgatókönyvnek megfelelően elvégzik a tesztelést és az eredményt tesztjegyzőkönyvekben dokumentálják. A teszt kimenetelést minden esetben jelenteni kell a tesztkoordinátornak. A tesztkoordinátor a szakértőkkel együtt megoldást keres a problémákra, majd frissíti a tesztforgatókönyvet. Ha a problémát megoldották, a tesztelő újrakezdheti a tesztelést, majd dokumentálja az eredményeket. Ha a hiba továbbra is fennáll, és harmadik félen múlik a megoldása eszkalálni kell a problémát a projekt menedzsernek. 

### 4.2 Tesztelési jelentés
A tesztelési jelentést a tesztkoordinátor készíti el. Ez egy részletes áttekintése a lefutott teszteknek, azok eredményeinek, státuszának és a megjegyzéseknek.
A tesztkoordinátor juttatja el a projektmenedzsernek a tesztelési jelentést. 

### 4.3 Tesztelt elvárások 
Az alábbi funkcionális elvárások szerepelnek az üzleti illetve fejlesztői specifikációban, amelyek tesztelésre is kerültek: 
> A dokumentum átdolgozás alatt (Hiányzó tesztelési elvárás a üzleti illetve fejlesztői specifikációban).

| #  | Leírás |
|---|---|
| 1. | GUI |
| 2. | Gameplay |
| 3. | Design |

Az alábbi nem-funkcionális elvárások szerepelnek az üzleti illetve fejlesztői specifikációban, amelyek tesztelésre is kerültek: 

| #  | Leírás |
|---|---|
| 1. | Felhasználóbarát felület |
| 2. | Gyors működés |
| 3. | Optimalizált |
| 4. | Megbízható |

### 4.4 Elfogadási kritériumok
- Technikai, a teszt forgatókönyvben leírtak szerint.
- A projekt menedzser jóváhagyása a teszt leszállítandókra

## 5 Tesztjegyzőkönyv
### 5.1 Tesztelési jegyzőkönyv - 1. 

|   |   |
|---|---|
| A teszt-eset leírás és célja:  | GUI, megfelelő megjelenítés |
| A tesztelt folyamat/funkció leírása:  |  Menü, ingame  |
| A tesztelés előfeltételei:  | - |
| A tesztelés dátuma és időpontja:  | 2020.12.12. |
| A tesztadatok típusa:  | Megfelel/Nem felel meg |
| A tesztet végző személy(ek):  | Kis Szandra |
| A tesztelt rendszer beállításai:  | Standard |
| A teszt-eset elvárt eredménye:  | Sikeres |
| A tesztelés eredménye:  | **Megfelelt/élesíthető**  |
| Megjegyzések:  | A menüpontok a tervezettként funkcionálnak, minden végzi a dolgát, hibát nem fedeztem fel. |

**Tesztelést elvégezte**

|   |   |
|---|---|
|  Név: | Kis Szandra |
|  Szervezeti egység/ beosztás: | Team member |
|  Dátum: | 2020.12.13. |

### 5.2 Tesztelési jegyzőkönyv - 2. 

|   |   |
|---|---|
| A teszt-eset leírás és célja:  | Gameplay, hibák felülvizsgálata |
| A tesztelt folyamat/funkció leírása:  | Enemies, powerups, movement |
| A tesztelés előfeltételei:  | - |
| A tesztelés dátuma és időpontja:  | 2021.01.15. |
| A tesztadatok típusa:  | Megfelel/Nem felel meg |
| A tesztet végző személy(ek):  | Csathó Zsolt |
| A tesztelt rendszer beállításai:  | Standard |
| A teszt-eset elvárt eredménye:  | Sikeres |
| A tesztelés eredménye:  | **Megfelelt/élesíthető**  |
| Megjegyzések:  | Indításkor azonnal indul a játék. A karakter és a pálya kinézete egyszerű, de mégis élvezhető. A alap zene és a hangeffektek érdekesek. Kezdéskor nem kell a gombora kettintani, automatikusan indul. A kilépés gomb nem működik. |

**Tesztelést elvégezte**

|   |   |
|---|---|
|  Név: | Csathó Zsolt  |
|  Szervezeti egység/ beosztás: | Product Owner|
|  Dátum: | 2021.01.15. |

### 5.3 Tesztelési jegyzőkönyv - 3.

|   |   |
|---|---|
| A teszt-eset leírás és célja:  | Zene , Hang teszt |
| A tesztelt folyamat/funkció leírása:  | Zene , hang |
| A tesztelés előfeltételei:  |  -  |
| A tesztelés dátuma és időpontja:  | 2020.12.12 |
| A tesztadatok típusa:  | Megfelel/Nem felel meg |
| A tesztet végző személy(ek):  | Pintér Bence  |
| A tesztelt rendszer beállításai:  | Standard  |
| A teszt-eset elvárt eredménye:  | Sikeres  |
| A tesztelés eredménye:  | **Megfelelt/élesíthető**  |
| Megjegyzések:  | A tesztelt folyamatok az elvárt követelményeknek megfelelnek.  |

**Tesztelést elvégezte**

|   |   |
|---|---|
|  Név: |  Pintér Bence |
|  Szervezeti egység/ beosztás: | Scrum master |
|  Dátum: |  2020.05.12  |

### 5.4 Tesztelési jegyzőkönyv - 4. 

|   |   |
|---|---|
| A teszt-eset leírás és célja:  |  Launcher teszt |
| A tesztelt folyamat/funkció leírása:  | Lacuncher gombok tesztje |
| A tesztelés előfeltételei:  |  Launcher elkészítése  |
| A tesztelés dátuma és időpontja:  | 2020.12.31  |
| A tesztadatok típusa:  | Megfelel/Nem felel meg |
| A tesztet végző személy(ek):  | Kis Szandra  |
| A tesztelt rendszer beállításai:  | Standard  |
| A teszt-eset elvárt eredménye:  |  Sikeres |
| A tesztelés eredménye:  | **Megfelelt/élesíthető**  |
| Megjegyzések:  | A tesztelt folyamatok az elvárásoknak megfelelnek, a gombok megfelelően működnek |

**Tesztelést elvégezte**

|   |   |
|---|---|
|  Név: |  név |
|  Szervezeti egység/ beosztás: |   |
|  Dátum: |  2021.01.06 13:58  |

### 5.5 Jóváhagyások

|   |   |
|---|---|
|  Név: |   |
|  Szervezeti egység/ beosztás: |   |
|  Dátum: |    |

## 6 Tesztelési jelentés 

### 6.1 Tesztelési jelentés -  1.  
|   |   |
|---|---|
| A hivatkozott tesztjegyzőkönyvek rövid leírása és eredménye:  | GUI, megfelelő megjelenítés |
| A tesztelt folyamatok/funkciók/modulok leírása: |  Menü, ingame |
| A tesztadatok típusa:  | Megfelel/Nem felel meg |
| A tesztelt rendszer beállításai:  | Standard  |
| A tesztelés eredménye:  | **élesíthető**  |
| Megjegyzések:  | A menüpontok a tervezettként funkcionálnak, minden végzi a dolgát, hibát nem fedeztem fel. |

**Tesztelést elvégezte**

|   |   |
|---|---|
|  Név: |  Kis Szandra |
|  Szervezeti egység/ beosztás: | Team member  |
|  Dátum: |  2020.12.30 12:15  |



### 6.2 Tesztelési jelentés - 2. 
|   |   |
|---|---|
| A hivatkozott tesztjegyzőkönyvek rövid leírása és eredménye:  | Gameplay, hibák felülvizsgálata |
| A tesztelt folyamatok/funkciók/modulok leírása: |  Enemies, powerups, movement |
| A tesztadatok típusa:  |  Megfelel/Nem felel meg |
| A tesztelt rendszer beállításai:  | Standard |
| A tesztelés eredménye:  | **Megfelelt/élesíthető**  |
| Megjegyzések:  | Indításkor azonnal indul a játék. A karakter és a pálya kinézete egyszerű, de mégis élvezhető. A alap zene és a hangeffektek érdekesek. Kezdéskor nem kell a gombora kettintani, automatikusan indul. A kilépés gomb nem működik.  |

**Tesztelést elvégezte**

|   |   |
|---|---|
|  Név: |  Csathó Zsolt |
|  Szervezeti egység/ beosztás: | Product Owner|
|  Dátum: |  2021.01.15 15:15  |


### 6.3 Tesztelési jelentés - 3. 
|   |   |
|---|---|
| A hivatkozott tesztjegyzőkönyvek rövid leírása és eredménye:  | Zene , Hang teszt |
| A tesztelt folyamatok/funkciók/modulok leírása: |  Zene , Hang |
| A tesztadatok típusa:  | Megfelel/Nem felel meg  |
| A tesztelt rendszer beállításai:  | Standard  |
| A tesztelés eredménye:  | **Megfelelt/élesíthető**  |
| Megjegyzések:  | A tesztelt folyamatok az elvárt követelményeknek megfelelnek.  |

**Tesztelést elvégezte**

|   |   |
|---|---|
|  Név: |  Pintér Bence |
|  Szervezeti egység/ beosztás: | Scrum master |
|  Dátum: |  2020.12.30 13:58  |

### 6.4 Tesztelési jelentés - 4. 
|   |   |
|---|---|
| A hivatkozott tesztjegyzőkönyvek rövid leírása és eredménye:  | Launcher teszt |
| A tesztelt folyamatok/funkciók/modulok leírása: |  Launcher gombok tesztje |
| A tesztadatok típusa:  | Megfelel/Nem felel meg  |
| A tesztelt rendszer beállításai:  | Standard  |
| A tesztelés eredménye:  | **Megfelelt/élesíthető**  |
| Megjegyzések:  | A gombok megfelelően működnek |

**Tesztelést elvégezte**

|   |   |
|---|---|
|  Név: |  Kis Szandra |
|  Szervezeti egység/ beosztás: | Team member  |
|  Dátum: |  2020.12.31 15:50  |

### 7 Jóváhagyások

|   |   |
|---|---|
|  Név: |  Csathó Zsolt |
|  Szervezeti egység/ beosztás: | Product owner |
|  Dátum: |  2021.01.15 16:00  |


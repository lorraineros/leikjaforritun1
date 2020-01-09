# leikjaforritun1

### 1. Game loop er lykkja sem keyrir stanslaust á meðan leikur er í gang. Hvert skipti sem lykkjan er keyrð þarf hún að process-a user input, uppfæra stöðu leiksins og render-a leikinn. Lykkjan þarf að halda utan um tímann til að stjórna rate-inu af gameplay-inu og lykkjan þarf að keyra leikinn á stöðugum hraða þrátt fyrir mismun í vélbúnaði.
### 2. Leikjavél er hugbúnaður sem styður við þróun tölvuleikja. Leikjavél er hugbúnaðarrammi sem hægt er að byggja þróun tölvuleiksins á. Grunnvirkni leikjavélar er myndsetning fyrir tvívíðar eða þrívíðar myndir eftir atvikum, eðlisfræðivél eða árekstrarskynjun, hljóð, kvikun, netvirkni og skriftun. Með því að nota sömu leikjavélina aftur og aftur er hægt að draga verulega úr vinnu við þróun tölvuleikja. 
### 3. collision detection virkar með því að í hverju update í gameloop er tékkað hvort að boundry á tvem hlutum krossast á eitthverjum púnt. 
### 4.Asset eru hlutir og tól sem hægt er að import-a og nota í project-um.
### 5. Game objects eru hlutir sem hægt er að setja inn í scene-ið og hægt er að breyta hvernig þeir bregðast við með því að breyta og bæta við components.
### 6. Prefab er tilbúið game object sem er með tilbúin components sem þú getur sett inn í svæðið í leiknum. Gameobject er eins og autt blað sem þú getur sett components inní það. Bæði eru mjög svipuð en ekki alveg eins svör fyrir leikjaforritun
### 7. Tags er góð leið til að halda utan um líka game object í leiknum. Layers er oftast notað í rendering eða raycastingtil þess að afmarka hvaða hluti þessar aðgerðir eiga að ná til. En það er líka hægt að nota það eins og við gerum íþessu verkefni í collision detection.
### 8. #### a) Scene view veitir aðgang að senuni án þess að þurfa að hafa camera gameobject sem fylgir með. Notað til þess að búa til senur.
#### b) Game view sýnir það sem myndavél í senunni sér.
#### c) Project glugginn sýnir öll Asset í leiknum
#### d) Hierarchy sýnir núverandi senu og alla hlutina í henni.
#### e) Inspector Sýnir components og stillingar í game object

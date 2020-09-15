# Raumschiff Tonstudio – Sound und Space im Virtuellen

---

### Idee
Dieses Projekt entstand im Rahmen des Aufbauseminars [_Auditory Spaces: Sound als Gestaltungsmittel in VR und AR_](https://lehre.idh.uni-koeln.de/lehrveranstaltungen/sosem20/auditory-spaces-sound-als-gestaltungsmittel-in-vr-und-ar/) am Institut für Digital Humanities der Universität zu Köln. <br>
Wir haben es uns als Ziel gesetzt, das Hörspiel [_Raumschiff Tonstudio – Bericht über das Innere einer Kapsel und deren Bewohner_](https://www.deutschlandfunkkultur.de/hoerspiel-ueber-den-brillanten-sound-raumschiff-tonstudio.3684.de.html?dram:article_id=456412) in einen virtuellen Raum zu übersetzen, der mit Ausschnitten aus dem Hörspiel auditiv unterstützt wird. <br>
Dazu haben wir ausgewählte Szenen aus diesem entnommen und in eine virtuelle Welt eingegliedert, wodurch  ein Narrativ entstanden ist, bei dem das Hörspiel weiterhin den Fokus des Projekts bildet. <br>
Bei der Umsetzung wollten wir eine Verbindung aus vorgegebenen Handlungen und freier Interaktion herstellen, bei dem den Nutzenden helfende Elemente angezeigt werden, ihnen aber auch die Möglichkeit gegeben wird, sich frei zu bewegen und zu experimentieren. Das Raumschiff als wiederkehrendes Element stellt dabei den Ankerpunkt der Anwendung dar, wie es auch im Hörspiel beschrieben wird.


### Allgemeine Informationen
* Gruppe N°10
* Mitglieder: Ackermann, Kappes,  Schunn, Steiger & Wagner
* Die ausführbare APK befindet sich im [/dist](https://github.com/dsteige1/AuditorySpaces_Gruppe10/tree/master/dist)-Ordner

---

### Technische Umsetzung
#### Generell
* Modellierung mit **Blender** und **3ds Max** (je nach System und/oder persönlicher Präferenz)
* Basale Materialien wurden in der Modellierungssoftware erstellt und nach dem Import in Unity angepasst
* Export der Modelle vorzugsweise im FBX-Format
* Programmierung der Interaktion in **Unity**
* Das **GoogleVR**-Paket (GVR) für Unity ermöglicht den Zugriff auf diverse Skripte und Komponenten, die die Programmierung von VR-Anwendungen für mobile Endgeräte erleichtern (z.B. den Zugriff auf das Gyroskop-System des Smartphones und folglich den Retina-Pointer und ein entsprechendes Event-System, um durch 'Blicke' mit Objekten interagieren zu können)
* Built der fertigen Applikation via Android SDK für die **Android**-Plattform

#### Modelle
* Größere Architekturen haben wir weitgehend selbst modelliert. Bei einigen Objekten haben wir uns an freien Modellen aus dem Internet bedient:
    * _Cartoon_Lowpoly_Car.fbx_ von [TurboSquid](https://www.turbosquid.com/3d-models/cartoon-city-car-3d-model-1362622)
    Darauf basiert auch das Modell _Car_interior.fbx_
    * _scifi_cartoon_rocket.obj_ von [Free3D](https://free3d.com/de/3d-model/cartoon-rocket-878331.html)
    * _SPIDER_PARA_VENTA.obj_ von [TurboSquid](https://www.turbosquid.com/3d-models/3d-spacecraft-1288438)
    * Die Baumelemente, welche in Blender zu einem Waldkontext (_Forest.fbx_) zusammengefügt wurden:
        * [Low Poly Tree](https://www.turbosquid.com/3d-models/sample-trees-c4d-free/1008420), [Low Poly Trees](https://www.turbosquid.com/3d-models/trees-3d-model-1189906)

    * _street_environment.fbx_ von [CGTrader](https://www.cgtrader.com/free-3d-models/exterior/street/street-87943b69-51c4-4f67-8d3c-ea772a7362af)

Built with Unity-Version 2019.2.12f1

---

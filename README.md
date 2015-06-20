# F# initiation

English & French readme available, see below for English version

## Français

Ce repository contient le code issu de plusieurs tentatives d'initiation au F# pour différents publics :

* Avec Simplon en Ardèche (201505), après 7 semaines de découverte de l'informatique et du Ruby, nous avons fait cet atelier en mode CodeCooking (voir ci-dessous)
* En Coding Dojo à Lyon (20150618), avec des développeurs expérimentés découvrant le F#, en mode Code Cooking également
* En atelier Mix-Teen à Lyon (201506), avec 4 enfants de 11 à 14 ans, 2 n'ayant jamais essayé la programmation, en mode Mob Programming (mais sans expliquer les concepts comme dans un Code Cooking)

L'objectif est de partir d'une feuille blanche et de créer un script en s'appuyant la librairie NAudio (donc seulement Windows pour le moment) pour jouer des notes de musique.
Il y a peu de chose à savoir sur cette lib :

* les multiples de 12 sont des DO, i.e 60 est un DO de l'octave 5
* +1 par demi-ton, i.e RE = 62, RE bémol = 61, RE dièse = 63...etc...
* on doit démarrer et arrêter les notes avec une temporisation entre les deux pour créer des croches, des noires...
La temporisation se fait avec Thread.Sleep x, où x est en millisecondes.
* on pourrait donc jouer des accords en démarrant plusieurs notes en même temps...

Pour rejouer, aller plus loin, voici ce qui est nécessaire (tout est gratuit, voire Open Source) :

* PC Windows (pour l'instant, car la lib NAudio utilise les fonctions de son Midi de Windows, je regarde quelle lib utiliser sur Linux...)
* installer FSharp : http://fsharp.org (Open Source, le framework en lui-même fonctionne sous Linux/MacOS...)
* installer un éditeur de code (je conseille Xamarin : plus simple à installer et gratuit)

Pour en savoir plus sur le langage F# : http://fsharp.org ou plus spécifiquement http:// https://msdn.microsoft.com/en-us/library/dd233181.aspx

En cas de problème, ne pas hésiter à me contacter sur Twitter : @clem_bouillier

### A propos du format Code Cooking 

## English

TO BE DONE :)
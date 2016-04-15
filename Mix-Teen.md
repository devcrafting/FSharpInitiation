L'atelier Mix-Teen d'initiation au F# a pour but de faire découvrir un langage de programmation avancé à des enfants de 10 à 15 ans, sans connaissances préalables en programmation.
A noter que beaucoup de développeurs ne connaissent pas les concepts sous-jacents à ce langage (la "programmation fonctionelle") et pourtant c'est accessible à tous :)...

# Mais que va-t-on faire dans cet atelier ?
On va tenter d'écrire tous ensemble du code (en F# donc) permettant de jouer de la musique (même si on ne connait rien au solfège!).

La clé est dans l'expérimentation : on essaie d'écrire un bout de code, on écoute le résultat et on recommence !

Un point important est de tous participer au même code, de mettre tous nos cerveaux en commun pour aller plus loin ! Et ça marche vous en ferez l'expérience !

On touche à des concepts avancés de programmation et de collaboration en équipe tout en s'amusant. Par exemple, une équipe a réussi à créer un programme jouant une partition de Harry Potter, puis en fin d'atelier, une fille a pu écrire "la lettre à Elise" en utilisant le langage créé par l'équipe pour représenter une partition ! Pour en arriver là, au menu : un chouille de math, du solfège, un peu d'anglais...mais sans que ce soit rébarbatif, promis :).

# Se préparer pour l'atelier en tant que participant
La bonne nouvelle: il n'y a rien à préparer pour les participants ! Juste votre enthousiasme :).

# Continuer à creuser le F# à la maison
Alors si vous avez aimé, et que vous voulez continuer à faire du F# à la maison, c'est possible et plutôt facile.

Si vous voulez continuer sur le sujet de cet atelier, un PC avec Windows est nécessaire (la librairie NAudio.dll, le fichier inclus au début du script écrit ensemble, ne fonctionne que sous Windows).
Voici les répertoires contenant les sources des ateliers passés:
* [Juin 2015](https://github.com/devcrafting/FSharpInitiation/tree/master/201506_MixTeen)

Mais vous pouvez aussi faire de nombreuses autres choses en F# sous Linux ou MacOS (cf. ces pages pour l'installation: [MacOS](http://fsharp.org/use/mac/) et [Linux](http://fsharp.org/use/linux/)).

Sous Windows, voici la démarche à suivre pour pouvoir écrire et lancer du F# (note aux parents: rien d'illégal, que des logiciels gratuits, et très peu intrusifs, i.e sans impacts sur les autres logiciels, mais nécessite un peu d'espace disque) :
* Installer F# (la référence -en anglais- est [l'option 3 sur cette page](http://fsharp.org/use/windows/)):
  * Sous Windows 7 seulement (SP1 min), installer ".NET 4.5": https://www.microsoft.com/en-us/download/details.aspx?id=42642
  * Installer le "SDK Windows":
    * Windows 7: https://www.microsoft.com/en-us/download/details.aspx?id=8279
    * Windows 8: https://developer.microsoft.com/en-us/windows/downloads/windows-8-sdk
    * Windows 8.1: https://developer.microsoft.com/en-us/windows/downloads/windows-8-1-sdk
    * Windows 10: https://developer.microsoft.com/en-us/windows/downloads/windows-10-sdk
  * Installer "Microsoft Build Tools 2015": https://www.microsoft.com/en-us/download/details.aspx?id=48159
  * Installer "Visual F# Tools 4.0": https://www.microsoft.com/en-us/download/details.aspx?id=48179
* Installer l'éditeur de code Atom: https://atom.io/
* Installer le package Ionide dans Atom:
  * Ouvrir Atom
  * Appuyer simultanément sur Ctrl+Shift+P, et taper "install packages and themes", sélectionner la commande proposée
  * Dans la fenêtre, chercher le package "ionide-installer", l'installer

Et voilà, il n'y a plus qu'à ouvrir un fichier de code avec Atom (fichier .fsx à télécharger sur ce site par exemple). Ionide va vous permettre d'éditer le code F# de manière fluide et avec l'aide contextuelle.

# Pourquoi ce langage ?
Le langage F# a l'avantage d'être facilement scriptable tout en ayant une vérification des types permettant d'avoir un retour visuel très rapide dans l'éditeur de texte sur des erreurs de syntaxe ou d'usage. Il n'est ainsi pas possible d'écrire du code qui ne se lance pas (contrairement à d'autres langages de script, beaucoup plus permissif à l'écriture avec des erreurs à l'exécution).

De plus, ce langage est un langage de programmation fonctionnelle, qui est une approche de la programmation qui se répand et qui semble plus accessible à tous que les autres paradigmes de programmation.

Avec F#, il est facile de faire des choses simples simplement, c'est-à-dire sans trop de "cérémonies" (créer des projets, ajouter des dépendances, se conformer à une syntaxe verbeuse et complexe pour le néophite...)

# Se préparer à animer cet atelier
L'atelier a été réalisé avec F#, mais n'importe quel langage permettant de facilement jouer des notes (en Midi dans le cas présent avec NAudio) pourrait s'adapter.

Il est nécessaire de connaître des bases de F# pour animer cet atelier, sans avoir besoin d'en être un expert.

Voici des pistes pour animer l'atelier:
* Donner les 3 fonctions de base (voir fichier script.fsx):
  * commencer note
  * arreter notes
  * attendre duree
  * et les déclarations les précédant
* S'exercer à appeler ces fonctions (sans forcément parler "d'appel de fonction", juste dire "et si on commencait à jouer une note"...)
* Choisir une partition à retranscrire (mais pas trop compliqué !)
* Commencer par essayer d'écrire les premières notes (donner le LA sinon s'il n'y a d'oreille musicale, ça va être compliqué :)
* En écoutant, les enfants devraient s'apercevoir qu'il manque le rythme, tenter de l'introduire (utiliser la fonction attendre...)
* Essayer de les amener à faire une fonction "jouer note duree"
* Commencer à écrire la partition choisie
* Peut-être que vous aurez à découvrir les octaves également...ce sera certainement le moment d'introduire un type Note (avec une octave et une durée, ou variante à base de tuple...)
* Ecrire une bonne partie de la partition et écouter (ça fait du bien d'entendre que ça marche!), au passage, demander comment pourrait-on écrire la partition plus lisiblement (par ex: partition = liste de ligne, ligne = liste de note...)
* Faire écrire une partition par quelqu'un n'ayant pas participé à l'atelier (mais connaissant la musique de préférence...)

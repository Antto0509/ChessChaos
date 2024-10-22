# ChessChaos - Jeu d'échecs

## Besoin

Créer un jeu d'échecs dans le cadre de la SAE 5 & 6 de 3e année. Les parties confronteront un joueur avec une IA à difficulté variable. Les règles du jeu d'échec devront être respectées, mais en supplément certaines cases et pions auront des compétences particulières.

## Gameplay

- **Mode solo** : 
  - Choix du niveau de difficulté de l'IA (Débutant, Intermédiaire, Expert).
  - Possibilité de sauvegarder et de reprendre une partie.
  - Affichage des coups possibles pour chaque pièce.
  - Système d'annulations et de reprises de coups.
  - Mode tutoriel expliquant les règles du jeu.
- **IA** :
  - Algorithme minimax avec alpha-beta élagage pour une IA solide.
  - Différents niveaux de profondeur de recherche pour ajuster la difficulté.
  - Évaluation de position basée sur des heuristiques classiques.
  - Intégration d'ouvertures et de finalités précalculées pour les niveaux de difficulté supérieurs.
- **Cases spéciales** : Certaines cases pourraient déclencher des événements aléatoires :
  - **Case de téléportation** : Transfère une pièce sur une autre case aléatoire.
  - **Case de piège** : Inflige perte de la pièce qui s'y pose.
  - **Case de bonus** : Accorde un avantage temporaire à la pièce qui s'y pose (bouger de deux cases, attaquer à distance, etc.).

## Règles du jeu

- **Déplacement des pièces** : Les pièces se déplacent selon les règles classiques du jeu d'échecs.
- **Prise de pièces** : Les pièces se prennent selon les règles classiques du jeu d'échecs.
- **Échec et mat** : Le jeu se termine lorsqu'un roi est en échec et ne peut pas se déplacer pour sort
- **Pat** : Le jeu se termine en pat si le joueur ne peut pas effectuer de mouvement légal.
- **Règles spéciales** : Les cases spéciales peuvent modifier les règles de déplacement des pièces.
- **Promotion** : Un pion atteignant la dernière rangée se transforme en une autre pièce de son choix.
- **Roque** : Le joueur peut effectuer un roque si les conditions sont remplies.
- **Prise en passant** : Un pion peut prendre un pion adverse qui vient de se déplacer de deux cases.
- **Nulles** : Les parties peuvent se terminer par un accord de nulles entre les joueurs.
- **Répétition de position** : Si une position se répète trois fois, la partie est déclarée nulle.
- **Règle des 50 coups** : Si 50 coups sont joués sans prise de pièce ni déplacement de pion, la partie est déclarée nulle.
- **Horloge** : Les joueurs disposent d'un temps limité pour jouer leurs coups.
- **Sauvegarde** : Les parties peuvent être sauvegardées et reprises ultérieurement.
- **Annulation de coup** : Les joueurs peuvent annuler un coup pour revenir en arrière.
- **Reprise de coup** : Les joueurs peuvent rejouer un coup annulé.
- **Coup illégal** : Les coups illégaux ne sont pas autorisés et doivent être rejoués.
- **Évaluation de position** : Les positions sont évaluées pour déterminer l'avantage d'un joueur.
- **Ouvertures** : Les ouvertures sont des séquences de coups précalculées pour les débuts de partie.
- **Finalités** : Les finalités sont des séquences de coups précalculées pour les fins de partie.
- **Heuristiques** : Les heuristiques sont des critères d'évaluation de position pour l'IA.
- **Algorithme minimax** : L'algorithme minimax permet de simuler les coups possibles pour l'IA.
- **Alpha-beta élagage** : L'alpha-beta élagage permet d'accélérer la recherche de l'IA.
- **Niveaux de difficulté** : Les niveaux de difficulté ajustent la profondeur de recherche de l'IA.
- **Mode tutoriel** : Le mode tutoriel explique les règles du jeu aux joueurs.
- **Case de téléportation** : La case de téléportation transfère une pièce sur une autre case aléatoire.
- **Case de piège** : La case de piège inflige une perte à la pièce qui s'y pose.
- **Case de bonus** : La case de bonus accorde un avantage temporaire à la pièce qui s'y pose.
- **Débutant** : Le niveau de difficulté débutant est adapté aux joueurs novices.
- **Intermédiaire** : Le niveau de difficulté intermédiaire est adapté aux joueurs expérimentés.
- **Expert** : Le niveau de difficulté expert est adapté aux joueurs chevronnés.

## Technologies

- **Moteur** : Unity 6
- **Langage de programmation** : C# et C++
- **Graphismes** : Modélisation 2D des pièces et de l'échiquier, animations simples, effets visuels.
- **Son** : Effets sonores pour les mouvements, les captures et les événements importants.
# **Pokemon-Like**

## **Description du Projet**

**Pokemon-Like** est une application de type RPG où les utilisateurs peuvent :
1. Créer un compte (**Sign Up**).
2. Se connecter avec leurs identifiants (**Login**).
3. Consulter une liste de Pokémon disponibles.
4. Explorer une liste de sorts (**spells**) attribués aux Pokémon.

---

## **Fonctionnalités**

### 1. **Sign Up (Inscription)**
- Les utilisateurs peuvent créer un compte.
- Informations requises :  
  - **Nom d'utilisateur**  
  - **Mot de passe**  
- Les données sont sauvegardées pour être réutilisées lors des connexions.

### 2. **Login (Connexion)**
- Les utilisateurs peuvent se connecter avec les informations suivantes :  
  - **Nom d'utilisateur**  
  - **Mot de passe**  
- Si les identifiants sont incorrects, un message d'erreur est affiché.

### 3. **Liste des Pokémon**
- Une liste des Pokémon disponibles est affichée.
- Chaque Pokémon possède des caractéristiques de base :
  - **Nom**
  - **Type** (ex. Eau, Feu, Plante)
  - **Points de vie (HP)**  

Exemple :  
| **Nom**        | **Type**   | **HP**   |  
|----------------|------------|----------|  
| Pikachu        | Électrique | 100      |  
| Carapuce       | Eau        | 120      |  
| Salamèche      | Feu        | 110      |  

### 4. **Liste des Spells (Sorts)**
- Les Pokémon ont accès à une liste de sorts.
- Chaque sort contient :
  - **Nom du sort**
  - **Dégâts**  
  - **Type** (correspond au type du Pokémon)

Exemple :  
| **Nom du Sort**    | **Dégâts** | **Type**     |  
|--------------------|------------|--------------|  
| Éclair             | 20         | Électrique   |  
| Pistolet à O       | 15         | Eau          |  
| Flammèche          | 25         | Feu          |  

---

## **Prérequis**

- **Visual Studio** ou **.NET SDK**
- **Framework cible : .NET Core / .NET 5+**
- **Langage : C#**  
- **Technologie Front-end : WPF**

---

## **Installation**

1. **Cloner le projet** :
   ```bash
   git clone https://github.com/ton-repo/pokemon-like.git
   cd pokemon-like

# TenisuApi - API Tennis Players

## Description
API REST développée en C# ASP.NET Core pour gérer les statistiques et la gestion des joueurs de tennis. L’application est déployée en ligne et accessible publiquement.

## Fonctionnalités principales
- ✅ **GET /api/players** : Liste des joueurs triés par rang
- ✅ **GET /api/players/{id}** : Récupérer un joueur par ID
- ✅ **GET /api/players/stats** : Statistiques globales (meilleur pays, IMC moyen, médiane des tailles)
- ✅ **POST /api/players** : Ajouter un nouveau joueur

## Accès en ligne
L’API est déployée sur Render et accessible ici :
👉 https://tenisu-1.onrender.com

### Exemples de routes disponibles
- [GET]    https://tenisu-1.onrender.com/api/players
- [GET]    https://tenisu-1.onrender.com/api/players/1
- [GET]    https://tenisu-1.onrender.com/api/players/stats
- [POST]   https://tenisu-1.onrender.com/api/players

La documentation Swagger est disponible (en mode développement) à :
- https://tenisu-1.onrender.com/swagger

## Technologies utilisées
- C# / .NET 8
- ASP.NET Core Web API
- System.Text.Json
- LINQ
- Swashbuckle (Swagger)

## Installation et lancement local
```bash
git clone [ton-repo]
cd TenisuApi
dotnet restore
dotnet run
```

## Auteur
Yacine Dahmoun

---
N’hésitez pas à contribuer ou à ouvrir une issue pour toute suggestion ou bug !

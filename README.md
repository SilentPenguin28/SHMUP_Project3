Project made by Dallas Mancinas

# Prototype: Space SHMUP

A small top-down space shooter I built in Unity. It's a classic "shoot 'em up" in the spirit of arcade games like [Galaga](https://en.wikipedia.org/wiki/Galaga), [Galaxian](https://en.wikipedia.org/wiki/Galaxian) and [Ikaruga](https://en.wikipedia.org/wiki/Ikaruga): fly your ship, dodge enemies, grab powerups and blast everything on screen.

## Unity version

This project is set up for **Unity 2021.3.45f2 (LTS)**. Open the project folder in Unity Hub and pick that editor version. The first time it opens, Unity will re-import assets and rebuild the package lock file, which can take a minute.

## What makes my game unique

I added a points counter. A score display in the top-left corner that starts at 0 and adds 100 points for every enemy destroyed. It resets when the player dies and the game restarts. The points per enemy can be changed in the Inspector (ShootEmUp → Points Per Enemy).

I added power ups. The powerups make the game more fun and you want to progress to get powerups throughout the gameplay to do better and better.

## Controls

| Action | Key |
|---|---|
| Move | Arrow keys or WASD |
| Shoot | Space (tap or hold) |

## Enemies

There are five different enemy types, each with its own movement pattern.

## Powerups

Destroyed enemies can drop one of three powerups.

### Shield

Picking up a shield adds a layer of protection around your ship. Each hit knocks it down a level instead of destroying you. It stacks up to level 4.

### Blaster

The blaster is the straightforward option: one shot fired straight ahead.

### Spread

The spread gun fires three shots at once in a fan, which makes it great for clearing out groups of enemies.

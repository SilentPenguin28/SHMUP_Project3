# Prototype: Space SHMUP

A small top-down space shooter I built in Unity while working through Jeremy Gibson Bond's book [*Introduction to Game Design, Prototyping, and Development* (2nd Edition)](https://book.prototools.net/). It's a classic "shoot 'em up" in the spirit of arcade games like [Galaga](https://en.wikipedia.org/wiki/Galaga), [Galaxian](https://en.wikipedia.org/wiki/Galaxian) and [Ikaruga](https://en.wikipedia.org/wiki/Ikaruga): fly your ship, dodge enemies, grab powerups and blast everything on screen.

## Unity version

This project is set up for **Unity 2021.3.45f2 (LTS)**. Open the project folder in Unity Hub and pick that editor version. The first time it opens, Unity will re-import assets and rebuild the package lock file, which can take a minute.

## Controls

| Action | Key |
|---|---|
| Move | Arrow keys or WASD |
| Shoot | Space (tap or hold) |

## Enemies

There are five different enemy types, each with its own movement pattern.

| Enemy 1 | Enemy 2 | Enemy 3 | Enemy 4 | Enemy 5 |
|---|---|---|---|---|
|![Enemy0](https://user-images.githubusercontent.com/17680666/165337714-16c8f7b5-98f8-4172-b1c0-1a3abf1f2814.png)|![Enemy1](https://user-images.githubusercontent.com/17680666/165337715-64534e59-cdd6-4b18-8131-3cbfa050ea3c.png)|![Enemy2](https://user-images.githubusercontent.com/17680666/165337717-df50a2b2-6938-409e-83b5-d578f62a8dac.png)|![Enemy3](https://user-images.githubusercontent.com/17680666/165337719-c90d87e0-f117-40a8-b0c6-5710c9da2356.png)|![Enemy4](https://user-images.githubusercontent.com/17680666/165337720-702d48ae-3f51-475d-8c37-f2779e6f476d.png)|

## Powerups

Destroyed enemies can drop one of three powerups.

| Shield | Blaster | Spread |
|---|---|---|
|![ShieldPowerUp](https://user-images.githubusercontent.com/17680666/165338608-3aff3c91-8139-4c73-b215-9474dd6e4fde.png)|![BlasterPowerUp](https://user-images.githubusercontent.com/17680666/165340108-41a6d5d4-f085-4fd5-b8bc-d43973e5acdb.png)|![SpreaderPowerUp](https://user-images.githubusercontent.com/17680666/165340112-e47996bb-fdab-405d-a42d-c028471dd7d7.png)|

### Shield

Picking up a shield adds a layer of protection around your ship. Each hit knocks it down a level instead of destroying you. It stacks up to level 4.

| Level 0 | Level 1 | Level 2 | Level 3 | Level 4 |
|---|---|---|---|---|
|![Shield_LVL0](https://user-images.githubusercontent.com/17680666/165338596-df4a1a42-a1b0-4f52-98a9-07a0436b4b1a.png)|![Shield_LVL1](https://user-images.githubusercontent.com/17680666/165338600-664c0a8c-519d-4194-86ab-fed546d87744.png)|![Shield_LVL2](https://user-images.githubusercontent.com/17680666/165338602-57a68d63-ffdd-4fcc-8e41-15bfda7a7f44.png)|![Shield_LVL3](https://user-images.githubusercontent.com/17680666/165338605-474a9c09-12c4-4534-b41d-23fba326b7b1.png)|![Shield_LVL4](https://user-images.githubusercontent.com/17680666/165338607-d2b51327-357b-499b-ba2b-d1103bf65ece.png)|

### Blaster

The blaster is the straightforward option: one shot fired straight ahead.

![Blaster](https://user-images.githubusercontent.com/17680666/165340104-3acf956b-fee8-41b3-8f58-b945b64961b0.png)

### Spread

The spread gun fires three shots at once in a fan, which makes it great for clearing out groups of enemies.

![Spreader](https://user-images.githubusercontent.com/17680666/165340110-d0bbbd58-a8f0-4597-8bf7-9dec1b5c6577.png)

## Gameplay

https://user-images.githubusercontent.com/17680666/165341681-4cb7ad08-61f4-4a5c-8587-56677059bcc9.mp4

## Credits

- Game design and starting code come from *Introduction to Game Design, Prototyping, and Development* by Jeremy Gibson Bond.
- Based on the original [Prototype-Space_SHMUP](https://shaman37.itch.io/prototype-space-shmup) project by shaman37.

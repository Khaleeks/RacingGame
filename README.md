# KhalRacing Circuit 🏎️

[Game Demo](https://youtu.be/YWghbzbFJl0?si=f_OY1GsuFGSLgpND)

## The Game I Built

I spent weeks creating this racing game, and honestly, I'm pretty proud of how it turned out! It's got mountain tracks, different cars to drive, and all kinds of cool features that make it feel like a real racing experience.

The project started as a simple idea but grew into something much bigger as I kept adding features. Each time I implemented something new - whether it was tweaking the physics for a particular car or designing a tricky section of track - I got more excited about the final product.

## The Tracks

### Dusty Bloom - Easy But Fun

![Dusty Bloom](assets/dusty.png)

Dusty Bloom was the first track I built, and it shows in its simplicity. It's basically a circular dirt track winding through some gentle hills with patches of greenery here and there.

What I love about this track:
* The wide, forgiving turns that let new players get a feel for the controls
* The way the dust kicks up behind your car as you speed around corners
* The sunset lighting I added that gives everything this warm, golden glow
* How you can see the entire track from certain vantage points

I actually used this track to test most of the game mechanics while I was building them. There's something satisfying about its straightforward layout that still makes it fun to race on, even after creating more complex tracks.

### Canyon Coil - Where Things Get Real
![Canyon Coil](assets/canyon.png)

Canyon Coil took me forever to get right. I wanted a track that felt challenging without being frustrating, and designing the layout through a rocky canyon setting was tough.

What makes Canyon Coil special:
* Narrow passages between towering rock walls that make you feel tiny
* Those switchback turns that require actual braking technique (I wiped out so many times testing these!)
* The dramatic lighting changes as you drive through shadowed sections and back into sunlight
* That sneaky shortcut I added through a gap in the mountain that saves like 5 seconds if you nail it
* The way the track surface changes from packed dirt to loose gravel in certain sections

There's this one hairpin turn about halfway through that I redesigned like six times because players kept flying off the edge. I finally added some subtle guide barriers and slightly widened the approach, which made a huge difference.

### Timber Fall - My Pride and Joy
![Timber Fall](assets/timber.png)

This track nearly broke me, but it's absolutely my favorite. Set in dense, mountainous forests with some icy sections at higher elevations, Timber Fall is brutal but beautiful.

The standout features:
* Dense green forests that create this tunnel-like feeling on certain stretches
* A crazy elevation profile that has you climbing and descending constantly
* Those ice patches I strategically placed on the most challenging corners (I'm a bit evil)
* Two incredibly risky shortcuts - one through an icy mountain pass and another through a super tight forest section
* Natural hazards like fallen logs and rock formations that create chicanes
* The ambient fog effects I added to the lower sections that change the visibility

The second shortcut in Timber Fall was actually an accident. During development, I found I could squeeze between two rock formations if I hit them at just the right angle. Instead of "fixing" it, I slightly widened the gap and kept it as a high-risk option for skilled players.

## The Cars
![Menu](assets/menu.png)

I wanted distinct cars that actually felt different to drive, not just reskins of the same model:

### The Red Speedster
* Available from the start
* Great all-around performer with balanced handling and acceleration
* Makes this really satisfying engine noise when you hit top speed
* Drifts predictably, which helps new players learn cornering techniques

The red car was actually the hardest to balance because it needed to be approachable for beginners while still feeling powerful enough to be fun. I spent days tweaking the handling model until it felt just right.

### The Blue Rocket
* Also available from the beginning
* Ridiculous top speed but twitchy handling
* Takes real skill to control on the tighter tracks
* Super light, which makes jumps more dramatic

I initially made the blue car way too difficult to drive. My playtesters kept spinning out on every corner. I dialed it back just enough to be challenging without being impossible.

### The Green Machine (Unlockable)
* Only available after earning enough race winnings
* Superior handling with just enough speed to be competitive
* Perfect weight distribution that makes it stick to the road
* Custom engine sound that I recorded and modified from my neighbor's sports car

The green car is special - it's actually balanced to be excellent on the harder tracks but not necessarily the fastest on Dusty Bloom. This was deliberate to reward players who've mastered the more technical driving skills.

## The Game Interface

![Menu](assets/main.png)

The menu system went through several iterations before I landed on something that worked well:

* Clean, intuitive layout that guides players through car and track selection
* Visual previews of each track with difficulty ratings
* Car stats displayed with simple graphic indicators rather than boring numbers
* That "random" button I added last minute when I realized sometimes players just want to jump in
* Progress tracker showing how close you are to unlocking the green car

The HUD during races shows:

* Current position among AI racers
* Lap time that updates in real-time
* Best lap time that flashes when you beat your record
* Lap counter with clear 1/3, 2/3, 3/3 indicators
* A subtle speedometer that doesn't distract from the road

After finishing all three laps, the camera does this cool 360-degree spin around your car. That was a last-minute addition that took way longer than it should have to implement, but it adds this nice sense of accomplishment.

## Sound and Atmosphere

The audio really brings everything together:
* Each track has its own musical theme - dusty western vibes for Dusty Bloom, tense rock for Canyon Coil, and atmospheric electronic music for Timber Fall
* Engine sounds that react to RPM and load, not just speed
* Environmental effects like wind on mountain passes or the crunch of tires on different surfaces
* Little details like birds scattering as you drive past in Timber Fall

---

Building this game taught me so much about physics, game design, and creating environments that feel alive. There were definitely moments when I wanted to throw my computer out the window (particularly when debugging the collision system on Timber Fall's shortcuts), but seeing players enjoy the finished product makes it all worthwhile.

I'm already thinking about the next track I want to add - something with water crossings and mud physics that would add a whole new challenge to master!

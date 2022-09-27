# Curation

## Introduction

This is going to be (in theory) a document where I'll write about curation strategies and so on - is that even a term? Anyway, I want to examine the set of potential assets and take notes about interesting works/assets and why they're interesting. I want to think about the curation heuristics and why I would choose one thing and not another. And I want to think about the actual exhibition staging and where I should put things and why I should put them there. And I want to think about any kind of information design that may well prove necessary.

I don't want this to function as a diary, I want it to be a practical document that gathers my thoughts together, okay? Got it, buster?

## Curatorial heuristics

My plan here is to develop a set of rationales for why one work and not another.

### Variety

* I think my baseline decision making should be around displaying a variety of assets at the price point so we can get a sense of the range, this will presumably invite the most questions from a player (and myself) and that's at the centre of this
* What kinds of categories are there that we can vary?
  * Resolution
  * Realism
  * Skill in execution
  * Size
  * Interactivity/activity
  * Genre connotations
  * Art style (cartoonish, low poly, realism, contemporary, etc.)
  * Quantity of elements (a single car, a collection of cars, a city, a room)
  * Genre of element (object, character, room, terrain, something else...)
  * Animation
  * Natural, fabricated
* There are a lot.

## Exhibition logistics

My plan here is to develop thoughts about how to position things in the space and why.

* Flatness. One issue is that some objects kind of require a flat space to actually work on. If you have a city street grid, say, you can't just embed the whole thing deep into sand dunes and still feel like you're doing is credit? So do I create cubic-platforms that support something like that and allow it to live its best life?
* Rooms. For interiors it may be necessary to build walls to enclose them depending on how they're implemented? I really loved my internal vision, at least, of walking into a kind of simple bunker and ending up in some beautiful room.
* Lighting. Various things look like they have their own lighting settings and preferences (and even rendering pipelines). I can imagine trouble on that front.

### Didacts

What shall they have on them?

* Name of the work
* Author of the work
* Category of the work (Is this like a medium? e.g. 3D > Environments > Landscapes)
* Price of the work ($4.99, duh)
* Size of the work (MB)
* Creation time/date of the work
* Version of the work
* Purchase date/time of the work
* **Maybe** some kind of further information?
* **Ideally** some link to the official asset page

---

# Installation notes

## 27-05-2021 15:03

* Dunes of the Sahara are not great for positioning largely flat objects
* Had to use a cube stand for the biological cells, but it did turn out well at least
* Can lay things out along the bottoms of dunes where it's almost flat, but that would help at all for a large object
* Possible that Sahara is a bad landscape for this, shit
* Lighting fucking sucks okay? Serious issue potential around the ways in which the producers of (perhaps mostly the larger?) assets assume the lighting will be handled - e.g. baked/non, relationship to GI, lighting systems embedded in the model, and so on
* Having partially installed the SuperStore I can at least say it's not a complete disaster? It also raised some interesting questions around things like colliders: the SuperStore doesn't come with them. Initially I'd assumed I would add them because... well because I wanted the store to be "real" in the space, but that's not actually showing you the asset as it is, and in fact the fact it doesn't have colliders is kind of interesting as an experience of the insubstantiality of things? So I put it on a plinth (a big one!) and this means you can walk level with the floor, but that's it. I should probably make some stairs in ProBuilder for the access points. Or rather ramps to be accessible!
* SuperStore has stuff on the top, do I need a viewing platform?! Wow. That's an interesting one.

## 28-05-2021 13:50

* Started install of BBlock yesterday (position) and finished it today (rotation and grounding). Epic process of looking at and moving every single one of around 680 individual pieces, some of which have really awkward shapes (I'm looking at you skinny shallow ramps!). The end result is honestly quite beautiful though
* Raises the question of informational plinth because it's such a large area - I've put one on each of the four "side", but it does still feel a bit like someone might not find them?
* been thinking, too, about map making and read some good ideas online about a special UI layer and associating symbols (UIImage) with that layer and then a sky camera that looks down on them. Should work well. Also still wondering about whether to "tick off" things as you view them, or just let the player/audience remember (probably that one). Wondering about the available resolution on the map and whether it'll display alright if I want to have dots for position and then also at least the title of each work? 88 things is a lot of things...

## 02-06-2021 14:12

* Added roadside marquee. Kind of disappointed to find that the prefabs don't actually have prewritten text on them, and I don't think it's probably fair to use the sample scenes to take them from? Or is it? Not really? Or IS it? HMMMMMMMMMM. This is an interesting question because with a scene the develop is explicitly trying to show off how cool their asset is, so that's a plus. On the other hand it adds a lot of potential contextual extras... gee I don't actually know what to do with that.
* In the end I did use the demo versions from the scene for installation - I think it's a more accurate vision of what the developer thinks about the asset, and I think that's okay.
* Installed low poly campsite. Ran into the issue of its demo scene using an asset for positioning I don't have so had to disable that (feels very much little a dirty little curatorial/installer secret moment). Other than that it works well. Well except the block it's on is super high, so I had to probuild some stairs up to it, but I like that! It's quite beautiful in the end and very chill compared to the desert all around it!
* While installing the ZOMBIE MoCap asset I ran into the fact that their demo animation controller only included four animations in a cycle which doesn't show off everything the thing can do, so I went in and added every single animation in a cycle. BUT it turns out that as far as I can tell this causes the character to move a bit through the cycle so it won't stay aligned... notably it won't stay with its plinth over time... need some way to correct for that. FIXED: disable Apply Root Motion
* Added Personality Animations Kit which is wonderfully blunt and also suggests "typical personalities" like "Sneak" and "Waiter". Oh god that's good. The animation names are so good I had to add a specific "from left to right" part to the label to explain what each one is because I don't want the viewer to miss out. It's a case of me explicitly commenting a bit which I don't know if I love, but it's too too beautiful.
* Added Prisoner-01 but CANNOT for the life of me purchase Prisoner-02... some kind of credit card issue? Why? It seems too scammy? Which is hilarious because it is kind of scammy to just sell these very basic models with the same animation set separately for $4.99 when you think about the other kinds of packages out there. But that's the point... I want Prisoner-01 and Prisoner-02 side by side with their separate plinths etc. to allow that to be a thought in the overall work.

## 03-06-2021 14:25

* The ongoing saga of Prisoners 01 and 02 has been ridiculous. First of all, Prisoner-02 seemed to be the moment that tripped the switch of fraud detection somewhere in the system (many small purchases on my credit card). I talked to both Unity and RBC support and they both steadfastly insisted it wans't them. In the end I paid with PayPal (same credit card) and bought Prisoner 02 successfully. Given how vaguely scammy the Prisoner assets feel, and the fact they're... prisoners... this seems very appropriate.
* Prisoner 01 and Prisoner 02 seem to be incompatible?! Importing Prisoner-02 seems to overwrite Prisoner-01's materials, turning him into a silvery Terminator kind of person. Not desirable. Right now I don't know how to stop this from happening.
* Fixed it eventually - happened because of the naming of the texturing components generically as "albedo" etc. along with the fact that (for some reason) the second prisoner you import will install into the original prisoner's folder (I'm guessing something to do with being from the same dev and they're meant to have a kind of meta folder possibly? Or just a shitty export of the package in general by Astronaut?)

![](images/prisoners-texture-problem.png)

* An extra funny observation just to wrap up Prisoner talk is that they have separate animation controllers that are essentially identical but slightly not, which means they'll get out of synch which is... funny. Ha ha.
* Downloaded and imported Deluxe animal pack v2 and have started laying them out, I settled perhaps too quickly on having the pack of animals in a line along a ridge... does that actually make sense? Good use of a ridge I think? And it has a solo-ride Noah's ark vibe to it? From smallest to biggest... I think it's okay. It's really tedious hand positioning thing though. And because these are animals that will be animated etc it's worse because there's more pressure to have them be lifelike and grounded.
* Hand positioned every animal in Animals deluxe v2 which took what felt like forever, but it does look kind of beautiful.

## 08-06-2021 11:34

* Finally placed all the low poly animals facing the others on the same ridge of a dune and it looks: gorgeous. I think this was a good idea thankfully. Now on with the show.
* Installed a cartoon owl and it is fucking great. It flew around! Had no expectation of that and it was pretty spellbinding. Also particle effects in the presentation of it. Was worrying it was going to be awkward but it's great.
* Can confirm the seagull has been a FUCKING NIGHTMARE. It's quite a simple object on face value, but it's equipped with the ability to fly, eat, attack, walk around. However, in the demo scene this is to be controlled by the player which... well I was thinking it made more sense to be controlled by the game with some shitty AI. But try as I might I haven't been able to make that work.
* Further, I haven't ever been able to get it to fly or take off or anything.
* As I was typing the first point about the seagull I suddenly wonder if it does actually make sense to let the player control the seagull if they're near the plinth?! I'm less sure about the flying but maybe the basics of walking it around? If I could reserve the arrow keys for the seagull and wasd for the player then you could stop at the plinth, read the instructions, and then walk the seagull around yourself a bit?! And make it eat and so on?! (But not fly? Flying is too crazy?) Would it be a bit like one of those flipping dogs where it would be on a plinth with a little rim around it to make sure the seagull can't get off... yeah gee...
* Well that's worth trying. Nope not really! Gets very fiddly because you do need a way to swap between Input meanings (since both my first person controller and the bird controller expect to use the default Axes defined in the Input component). You'd need some kind of complicated message on the plinth telling them to hit some specific key to toggle seagull versus player and it's just not what I want. Why the sweet fuck can't the thing at least walk in a reliable CIRCLE and pick the ground occasionally? THAT IS ALL I WANT FROM IT! I can even live without the flying part which sucks but seems out of reach. GOD DAMN!
* So currently the seagull is feeling like my first major failure... depressing. I should probably move on and install something else less finnicky? Bodes ill though...
* God bless her Rilla had the genius idea of just going with the controller nature of the seagull and saying "fuck it". So the result is a plinth with info about the seagull including controls, then a plinth it stands on at the beginning. But of course in the course of finding that information you'll end up causing the seagull to be elsewhere - you might even run into it while you're walking around and not quite understand you're controlling it?! You might want to go looking for it after you realize what's going on with it? I mean, that's pretty, pretty good. We need walls around the play area (and perhaps up top?) in order to prevent the seagull from being totally lost to play, but basically this is brilliant I think.

## 30-06-2021 11:10

* Added the Swordfish PBR without any real trouble. A reminder of how slow this can be even for an easy one though, what with interfacing with the Unity store, then waiting to download and import, then positioning, then making the plinth, etc.
* The Swordfish is nice because it comes with an animated model and a ragdoll which is quite interesting. It's one of the few interesting ways one of these models can respond to the train in a really appreciable fashion (by flopping on it). Interesting, of course that even this realistic swordfish has animations revolving around incredibly boring game tropes: Swim (fine), attack (Hmm), hurt (geez), dead (oh boy).
* Added Low Poly Fish Pack 1. It's kind of similar to the animal packs to be honest, which is perhaps vaguely disappointing, but in a way it shows a common situation on the store and the most obvious choices you might end up making. The animations for the low poly fish are somewhat useful in that they're the same as above, but explained in the text I'm then able to quote on the plinth. I quite like that their death idle animation just has them bobbing up and down in imaginary water. Fish out of water man.
* That reminds me I had a brief vision of putting the two PBR Swordfish into plinthy situations to evoke Hirst's shark, but I think that's overdoing it in the end.
* As I add more things in proximity to each other, the whole thing of vistas behind the current one you're looking at is really quite nice, with the supermarket and prototyping hill visible behind these latest fish, for example.
* Oh yeah, also meant to say that I'm thinking of added the size of each package to the plinth as a kind of materiality thing, how big these things are is always kind of intriguing. Could add number of files too, but I think that's a little less interesting?
* Added 73 animated butterflies. They're beautiful. Made the decision to position the plinth so the butterflies are nice and bright... though now I look at them it's weirdly on the opposite side to the sun? Is the idea that the light shines through their wings? If so that's very beautiful.

## 02-07-2021 13:58

* Made a shitty informational wall with a door in it just as a placeholder to remind me that I need to make that aspect of the game at some point. Struggled with ProBuilder and snapping, so it's pretty goddamn horrible, but that's la vie. Main thing is it's there to remind.
* Added the Egypt Spiders finally deciding they're definitely in after the little cultural appropriation question etc. They look pretty cool. The demo they come with is boring (just controlling them moving around) and in the end I kind of posed them coming over a dune toward the insects which is quite pleasing. It was a real snap decision though and does make me question how well I'm thinking about positioning as a part of this. I just mostly feel like I can't afford to take it too, too seriously or I will never get this thing made. To some extent so long as the player can see things and know which thing they are, my job is done?
* Added the Cu Puppies and they are FUCKING TINY. I kind of cannot believe just how small they are. It's the first instance, maybe of something having a scale that doesn't make sense to me, and I like that. They're miniscule, more like insects. Add to this that I also added Oscar the Dog from Omabuarts and he is BIG, kind of like a moving balloon animal.
* Fun that both dog types have a sets of animations they rush through, which evokes that sense of a dog that's eager to please. I like these additional moments of sigification outside the basic "this is what you're paying for".
* The Oscar dog comes with multiple LODs which, I mean I don't 100% understand, but essentially versions of the model that are simplified based on how far away it's going to be viewed from. It's nice to present these together because it gives a sense to the viewer of that particular technology and, therefore, of that particular technology having value.
* So, puppy power.

## 16-07-2021 12:26

* Installed exactly one asset, which was T-Rex Model. There turned out to be five prefabs in different sizes and textures, so they're in a circle around the plinth. More and more I find I'm reaching for interesting ways to stage the models to avoid things feeling ultra-repetitive, but I kind of wonder if that's a good idea. In this instance I thought it would be interesting to have to walk into the centre to see them. I also for the moment haven't linked up the animation controller to show every animation state, they're just idling, swinging their tails, which is quite nice.

## 19-07-2021 20:32

* Managed to get "Tyrannosaurus rex dinosaur" installed. It's quite old (2015) and uses the legacy animation system and was set to default to "stand still" which is no animation at all. Had to load their scene and try to figure out a bit of how to make it play any animation, but did get the idle animation going, which matches the previous T-Rex.
* It's pretty underwhelming overall? But it's totally fine. I think there's merit to comparing the two across their year, animation, texturing, etc. There's a funny thing there where there are "more" prefabs of the other t-rex, so is it more valuable? Technically yes? More textures, more content... value value

## 22-07-2021 21:04

* Installing Maksim Bugrimov's monster pack, which attracted me from the first moments I saw it as a kind of monster cabaret thanks to the synched animations. I've now seen a ton of synched animations, of course, so it's less spectacular, but I do think I still like it none the less. It's huge though, almost half a GB? I mean... will this game end up breaking some limit and being impossible to actually build?
* Okay, having actually watched them do their thing they are GREAT. They're like male strippers? Like a Magic Mike kind of thing? I love them very much.

## 28-07-2021 20:44

* I failed to write about the fact I partially installed the Mythological Creatures Pack - Norse a couple of days back. That involved mostly just the process of buying them and popping them in and realizing they're not animated which was quite weirdly disappointing - I've already started to develop certain expectations about what a model pack might involved, though I do see that they include the rigging for standard humanoid animation, which I suppose it close to being as good. But of course because of the way I'm working, I don't add anything like that, so they're just like statues in the sand.
* This evening I moved them into a configuration with the Cabaret/Chippendale Monster Pack which are dancing up a storm. Kind of an interesting confrontation? Like an impassive sports team watching the other team do some kind of dance (or even a haka, though it doesn't have quite that spirit? Though maybe it kiiind of does because a lot of the animations are attack animations?)
* Also there's an "elephant god" in this Norse mythology pack? Seems legit...

## 28-07-2021 21:40

* Already, I've now installed FPS HandJacket and it's pretty fun. It's a pair of arms that are wearing what would be a jacket plus some gloves, with the kind of implication maybe of being the sort of terrorist from Counter-Strike?
* They're quite wonderful! They're nothing more than that description - no code or functionality, just arms, not even arms that look like they would work well as arms in an FPS because I beleive you need some kind of distortion to make them look alright on a camera. Still, not my problem because in this case they're just on the ground - I ended up embedding them in the ground sticking up which looks great and vaguely implies a guy buried under the sand which... well, actually that's fairly interesting too - imaginative possibilities, but also fairly clear from all the other installations that I'm not doing that, so you kind of do know from that (and the information) that it's literally just some fucking arms.
* Love it.

## 09-11-2021 09:54

* Okay well as yo umay be able to notice it's been a while... like around three months and a bit. Not amazing but I've been writing a book and teaching my classes so I think that's not so so terrible right? The plan is to find my way back into this by, yes, installing some stuff. So Unity is open and I'm trying to work out what the next installation piece is.
* It's meant to be... Casually Dress Man. So here we go. I thought I had a list of the stuff I was installing somewhere though? Maybe it's above? No... I thought I had a new list. Oh there it is at the top of works.md okay fine.
* Well he's in there. Because he doesn't come with any animations he stays in t-pose which I think is kind of a good thing actually, I don't think we have any t-pose people in the park at this stage, so that's a plus. He's rigged and has "extra facial bones" for expression animations. He's quite small? Or... maybe not actually... I put a cube next to him and he seemed fine.
* Oh! My next one was meant to be a Fantasy Characters Pack but lo and behold it's not there any more. I remember this category being fucking hard as well and now on top of that I'll have to find a new one. Deprecated! Moving on to the Fantasy Ice King for now and then I'll trawl.
* The Ice King is another t-poser which is funny. He's animated on the asset store but they don't provide the animations in the pack. Can't quite decide whether I think that's a good thing or not. Providing animations makes the thing more lively in the world which means you maybe get more of a sense of personality and potential, but not including them forces you as a developer to pause and actually think about what they could do? So it's not a given that it should be one way or another? He does come with his own little stand which I really like about him.
* Okay time to find a new fantasy person! And we now have Mystic Clothed who is kind of bad (and is the close cousin of Mystic, who is unclothed and only has undies). In the end I wasn't going to do it in favour of some better model, but the description for Mystic Clothed includes the paragraph "Includes mouth" and I just could give up on that, it's too great that it's a big deal to include the mouth. Like that's the value we're looking for. Also it's interesting in that its versioning is "draft" which I hadn't seen before and I like that too.
* Threw in the Firefighter in the Aluminized suit and he looks appropriately fancy. He ended up near Casuall Dressed Man which I might have to change? But which might also be fine? I dunno.
* Okay and now I've popped in Adam who is the other "Human". I'm realizing that I think I had been putting objects from the same category explicitly close to each other and I didn't do that with the last couple. Something to revisit. I think there are merits to it for the direct comparison, and even merits to having "areas" in the park devoted to larger categories too, but there's also something to be said for a random spread of stuff? I'm not quite sure how it'll feel. A lot of the elements are fairly easy to organize/move, so it's not a worry yet, but I should make a decision soon because I imagine there will be other hard-to-place thing (thinking about the hell that was BBlock).
* We're now up to sci-fi I think, and we're aaaaalmost free of 3D Character and on to environments which I'm very much looking forward to.
* ScifiHuman01 is now in the game and he looks so awkwardly muscular, I'm really enjoying him. He seems very sedate too, just walking forwards and then backwards (I looped the animation but otherwise left him alone). Couldn't quite use Root Motion with him because although he walks forward, then back, then forward, then back etc. he actually takes more steps backwards than he does forwards, so he'd end up wandering away off the map which is a bit sad. I like him.

## 10-11-2021 (10:26AM)

* Started installing the VR hands and their scripts threw a ton of errors. To the point where, given the hands are not going to actually WORK I just deleted them, though now I very vaguely wonder whether they should be attached to the player? But also... no that's a bad idea so no? So they're just two hands in the sand that don't do anything. How do I explain there's more? Am I not doing them justice?
* Hmmm, this one is problematic. I can't seem to hack the animations together to at least loop and imply some of the work that exists to get this stuff working outside of an Oculus context which my game won't be in. That renders them just as a pair of tiny hands in the sand, which I don't deny is funny, but I'm not so sure this meets the standard of any arguments about the value of the object? Refund? Keep them as a lesson learned?
* Yeah it's not okay. So I've written for a refund in case they're feeling kind, and if not so be it. I'll look for a different asset from the category now.
* Alright we're going with Biolumenescent Alien instead. It looks beautiful. Why did I not choose it before? Alright well Area 51 Alien - Bioluminescent Alien and UFO is "in" but there's work to be done. The fact the alien has a rigid body is pretty funny because it literally falls over and rolls down a hill, but that's clearly not exactly *ideal* so I may need to disable the rigid bodies. Two of the aliens stay in t-pose because they're rigged to work with a third-person controller I don't have in there, I guess I could put one in, but then they'd probably be controllable by the keyboard and I don't know if I desperately want other things walking around. Also the tractor beam gets larger on play which I don't understand, not the end of the world but irksome nonetheless. So a few things to line up before it's ready, but the fact there's a UFO with a beam and three aliens is... pretty cool.

## 10-01-2022

* Made a snap decision to just remove the rigid body components from two of the aliens so they would stop falling over and rolling down the hill. It's kind of against what we're doing, but it's fine. It looks quite good and I appreciate having someone(s) in t-pose actually.
* Adding *Brute Robot* now. Quite a big one, I'm noticing the download time, it's like 300MB+. I do have some idle concerns that I'll get this whole game done and together and the release will be like 20GB or something! but I guess it so then... so. That's the size of it etc. ha ha. There are a *ton* of different renders of this robot? I'll look at the example scene, but otherwise it might end up being one of those dance lines again? Weird. Or a little field of them I suppose like the butterflies. So there's a scene that has every single one just kind of standing around? Not very inspired so I could either reproduce that on a plinth or just place them in a group myself. I made a nice grid **but** then I think I fucked everything by modifying the original plinth text which somehow messed up some but not all of the variants? What? Why? Well yep, that's fucked. So I guess I'll continue modifying the underlying plinth now and then go back and redo everything later, fuck me. Okay, well I lost a bunch of plinthormation (GET IT???) but here we are with the robots in place and their plinth. Just have to go back through and fix all the busted plinths at some point.
* Added the *Sci Fi Turrets* and they're nice. Spent some time fiddling a little with their animation controllers which don't show them shooting/activating by default but it was more than my time's worth to figure it out. One of the nice things here is that the creator includes a scene in which the turrets are shown as if they're a pottery exhibition or in some kind of consumer electronics showroom, so there are pre-made plinths which I really enjoy with them. Feel safe that I'm "showing them off" in the way the author clearly prescribed.

## 11-01-2022

* Holy shit am I working on two consecutive mornings?!
* So, actually today I've run out of my minicurated list in the [Works](./works.md) file so I'll need to build up the list again. We're up to Environments! This is a huge moment because these are big fucking things that may break it all. Exciting!
* Well I've added the New Dungeon Pack Modular Low Poly ... pack... to the project. It involved importing a TON of packages I don't think I really want in the project, all because of its test scene I suspect. However the test scene did provide a pre-made arrangement of the various elements in the pack and represents the gold standard (mostly) of how the creator wanted their work to be demoed. The proviso being that they used a bunch of post processing (and a different rendering pipeline for the materials) which I had to omit/change. So it doesn't look exactly right but right enough. One funny thing is that it has no roof, so it situates in the desert totally fine. The footprint isn't massive either which is helpful.
* Yikes, added Medieval Dungeon & Torture Chamber and it's a bit tricky. Notably I had to scale down the avatar to be able to get down the stairs and into the actual dungeon area, which may have implications elsewhere (though I've noticed the avatar being a bit too tall in other places so it may turn out to have been pretty useful anyway). It also has no actual point of entry - the stairs down come out of an impossible to reach room, so I suspect I'll have to remove a wall and then add, perversely, stairs that lead up to the stairs that lead down. I don't think I can embed it down into the ground because I can't cut a hole in the terrain. And any idea of teleporting people into environments feels wrong because then they're not truly situated in the desert. So, that's the plan. So far it's working okay though I think. I'm realizing I put it in the "wrong" place in that its not near to the other dungeon pack, so I'll rectify that now. Not I "just" need the stairs and the plinth and it's installed. Not too too bad.

# 12-01-2022

* Three?! Three consecutive days?!
* I've been putting the final touches on the dungeon, adding some stairs. I'm having quite a huge amount of trouble with Probuilder (which I use for stairs) which worries me. The new shape menu just isn't showing up so I had to copy and tweak a set of stairs I already had (for the owl campsite thing). Doesn't bode especially well, but I guess I just keep going. I'm wondering if it's something to do with that asset that require installing a ton of extra packages fucking up my properly installed probuilder, which I don't think it even really needs? Maybe I should delete its probuilder package and restart? Hmm. Anyway, the stairs look good. One feature of making the avatar smaller to fit this dungeon is that now I suspect all the plinths will be too high, so that's something to look at later.
* Added the Fantasy Ruins Pack successfully. It's quite expansive which feels good and, as predicted, looks so at home in the desert. Hilarious that they've misdescribed the pack as a "village" in the store, so I used that as the quote. No colliders which I don't mind... something nice, maybe about the permeability of stone like this. I put the plinth kind of in the central area so you have to walk into the ruins to find it. Quite lovely and a good thing in terms of showing off some of the "bigger" assets. Also fun that its file size is actually so tiny.

# 14-01-2022

* Okay well all good things come to an end and I needed to look after Felix yesterday morning, nixing my "streak". That's totally fine and now we're back to installs.
* I need to select the second of my fantasy environment. When I was just going through everything prior to actually having installed much I was excited about the medieval forge. It's very beautiful and so fancy BUT it's also almost 1GB all on its own which is lightly terrifying in terms of the project's size? But then on the other hand... should that be part of my decision making? Not really right. Worst case I buy it and then pivot if it's too much? Right? Yeah. That makes sense to me. Plus I think the fantasy runis pack is sufficiently gentle/low poly that it makes sense to pair with something ultra ambitious?
* Well the forge went in relatively easily which shocks me. The biggest issue is that it has some very cool things upstairs but its stairs don't have colliders and its door is closed! Should I remedy this or must they remain unseen? Hmm. Okay actually just adding a mesh collider to the stairs made it work totally fine, though the door is solid and you have to walk through the wall. What are my obligations to making it a more navigable structure here? For instance I left the supermarket totally alone but now I'm adding colliders. It's all about being able to see stuff right, so I suppose I should open the door as well? Which I did and that works just fine. It's a nice display, much easier than anticipated actually.
* Looking at the Historic category now. There's a lot of nice stuff. I'm leaning Ancient Pyramid and Wild West Town as I think that's a pretty nice combo and they lean "history" in a clear way. The Taj is pretty lovely though as an idea, definitely communicates a part of the world that doesn't necessarily get a lot of play and fun to be able to visit the Taj casually in this game. HMM. I think still it's pyramid and Wild West. Shit, still torn on that pyramid... it's somehow underwhelming me and making me want something else. I'll look again. I feel like Wild West and the Dock are a bit too similar The farmhouse perhaps not historic enough. The ruins are a bit too close to the ruins I already have. So maybe the Taj does win?
* Well onward with the western... and oh boy when I paste it in we have our inaugural scaling issue. The town is scaled biiiiiiiig. BIG. This will be a test of my "leave it the same as the demo" versus tweaking things to fit the environment. Most things tend to be scaled to a standard unit but this one is massive... I kind of can't see me keeping this at its size... the most obvious thing it to scale to the avatar's height based on a door or something right? Ah shit but then I go in to experience it at its "natural" size and it's kind of amazing to be so tiny compared to a wester environment... what does one do? It's not really what they "mean" by their town - it's not a giant western town, so by just pasting it in and not changing anything I'm really not honouring what this thing is presumably about. So although it's funny I think I do have to scale it down perhaps unfortunately. The scale thing is a subject for another day.
* Yeah so I scaled the town down to the avatar's current scale and it does feel nice to have it be relatable in that way. The priviso being that I need to work out whether it should be "in situ" sunken in the sand with this layout, or whether I should lay it out so that it somehow fits the dunes (which would make no sense in terms of town planning), or whether I put the entire thing on a plane (textured with their texture) and elevate it with stairs in the usual way. Leaning to that last one but out of time for right now to put it in practice. A success though.

# 17-01-2022

* Alright the wild west buildings are now installed correctly. They look quite nice on their plinth. Really the plinthing is kind of fair for every environment that comes on a plane anyway unless its usage strongly suggests that it should be laid out more organically in a landscape? 
* Now we return to the question of the other historic building. I've started leaning Taj funnily enough. Ancient Pyramid feels too pat and not enough of a historic reference in a way. The Taj is so recognizable. And such a funny thing to own (like the Sahara desert) - it has brand recognition. Okay I'm sold. Wonder how big it is though... shit.
* As I wait for it to download I feel very slightly sad it doesn't represent the whole compound/grounds because that would be yet more evocative - notably the reflecting pool(s). Having been there in person it would be funny to be able to recreate my own experience, but I think with the grounds it feels a little bit cookie cutter, more like a toy than a place? Well let's see what it's in.
* As is often the case with these larger models (see SuperStore) the Taj has no colliders anywhere which means you just walk through everything. I put it on a stand but should I be added mesh colliders or not? As it stands you can still see the Taj kind of from underneath (interesting for a tomb) by walking through its boundaries, but of course it in no way resembles the real thing so I'm a teensy bit unclear on whether this counts as showing it off? It's a question of what it means to see something not just with eyes but with your body? How does walking on the Taj change your perception? It clearly changes literal positioning for one thing but also some kind of sensory understanding, the empherality/insubstantiality makes it weird and unreal? Anyway, first approximation is no mesh colliders. So just some stairs to get up on the stand and a plinth.
* Disaster strikes: the stairs are too short to reach the stand. I really need to fix probuilder. I am trying the sort of horrifying step of uninstalling ProBuilder and then (hopefully) installing it again. Please don't destroy my project.

# 19-01-2022

* Wasn't able to get time in yesterday because I had to work on a talk for the VAC thing, but that's squared away now. All's well.
* As I was glancing at Unity just now I thought about how the Taj model is funny in that it's very vertical and you don't actually get to see, for instances, the tops of the minarets up close. Which is just like life too, but just interesting to think about that sort of accessibility of visibility? This is part of what the whole LOD world is for too - why bother to have detailed tiling up there if nobody will see it... did they do that on real buildings? Just phone it in on the bits that nobody was going to see? I wonder.
* Oh right I'm also trying to get PB working. Does it? No. Fuck.
* Okay well the Taj is in. I had to create a horrible prefab of two sets of stairs joined together with a cube since PB isn't working. That's deeply alarming when I think about other structures that could need to be built. Here's praying I don't need the flexibility of ProBuilder. Feels very oldschool not to be able to use it. Fucksticks.
* Anyway that takes care of the historic category with the Wild West (kind of pseudo historic I guess, more like movie historic) and then the Taj (genuinely historic but also a contemporary space which is nice).
* Onwards to the 3D > Environments > Industrial category. Which is very exciting because I seem to recall some ultra cool shit in there.
* Ah and indeed here we have Station v1 which is one of the ones I remember being very excited by when I saw it. I total environment that's not a building but rather a kind of rocky outcropping thing. Let's see if it fits?! It fits just fine but had zero colliders. This doesn't feel right so I added mesh colldiers so you can walk around on it - clearly the intention? This makes me suspect that Taj should get mesh colliders too? Am I eventually going to have to go through and fine tune mesh and box colliders for performance or will it just come out in the wash? So far the performance seemed fine (on my machine in Unity... so fuck knows...)
* BUT ANYWAY it looks very beautiful indeed and I am in love with it. It's in plinth and all. Lovely. Next!
* Struggling a bit with the other. There are some nice things but they either don't seem very "industrial" (abandoned church? trailer park home?) or they don't seem very environmental (a hermetic door?), or both really. The other major environmental one is a hydrodam that I fear would just be totally enormous and impossible to work with successfully. Then there's a warehouse area but it feels vaguely like that sort of thing is covered by station v1 already? I'm a bit unclear on how to proceed with this. Is it okay to, for instance, take the door because it is in the category even if I'd suggest its more of a prop? Does that illustrate something about the whole idea of categorization in the context of the project? It's an interesting side-by-side where one thing is huge (including doors) and one thing is little and maybe not quite in the right place? Not the worst thing in the world. Am I talking my way into this? Is this wise? I do like the basic image of a door... but do I have options for that later in props? Well searching through I don't actually see other doors so it wouldn't be a repeated image necessarily? So perhaps that's an okay reason to have it. It's just it's five bucks you know? Which isn't a huge deal but I don't madly want to spend it for something I shouldn't include. Do I need to go back through the category as a whole?
* Okay well a couple of things. There are TONS of things that aren't really environments in the category so it's not a one off oddity if I did take the door. It's like some creators put things in there because they don't see them as a prop I suppose? More like an "environment artist asset" kind of idea? I'd say the door is a prop, but I suppose I can see the argument for environment. The other thing is I did see two assets I didn't seem to consider previously? Or rather one... there's a gas holder that I did like but it looks a bit shitty on the page. But there's a gantry that's quite stunning. I quite like this. The reason I hadn't considered it is it was popped up in August last year, after my curatorial review. So let's do it!
* Okay well the gantry stuff is really nice but the previous scene is huuuuuuge (scale wise) so I'll need to chop it down a bit to realistically include it. I think that's okay so long as I include all the component pieces.

# 20-01-2022

* Got the gantries trimmed down and plinthed. They look nice and it's fun how they kind of relate to the Station v1 area too, some continuity which is interesting maybe especially because I don't think that's the norm... I'd have to look at them more closely but at the very least they kind of invite direct comparison/integration which may lead to an ability to spot various elements that contribute/detract from that idea?
* Just bought and added Bridge vol.2 and they are ludicrously tiny. This is one of those scaling moments like the Wild West. Obviously they don't "intend" the bridges to be read as extremely small so do I scale them up to an appropriate size given the world? I suppose I do. I did, they look nice and it's satisfying to be able to navigate on them rather than the "joke" that this is the size they came in... not really hilarious. The CuPuppies have the same issue so I'll have to think about whether I scale them up? And whether I scale too-large things down?! Hmm.
* I'm a bit torn between the Traffic and Roadside objects versus the Racetrack Mino. The racetrack is more clearly a form of Roadway, but that's just being a category police. The roadside objects are much more delightful to look at. I suppose I just answered my own question. Okay.

# 26-01-2022

* Been a minute, which is fine, that's what happens eh. I scaled up the bridge. What's next? Oh right. Roadside objects. On y va.
* Installed the roadside objects. They raised the repeated question of how to handle sets of elements, particular when I lean toward using the creator's sample scene presentation as a guideline. So these objects are (like many) presented in a kind of organized, griddy fashion. Which you can't mimic well on the slopes of a desert. So I put them on yet another pedestal but IS THAT RIGHT? Should I actually be dumping them in the desert and making them more in situ? Or more exhibitiony? I really don't quite know. I know that if they were more kind of piled up/fallen it would look more naturalistic in the context of the desert... but it also wouldn't necessarily be exhibiting them to the best of their ability, which is perhaps unfair to the owners. So it's tough. Aesthetics/look/coolness versus honour? Leaning to honour for now I suppose.
* Well and there's a third way which would be to do my best to *integrate* elements into the desert. Not dumping them but positioning them with care. I've done that for a bunch of them too, but now that I'm generally putting environments up on pedestals to avoid issues with the desert clipping into their spaces it gets harder to see what the line I'm drawing it? Like if some things are kind of integrated into the desert and some aren't then... why? Also I have plinths everywhere which is already totally unnatural/art-context, so why not pedestals? HMMMMM.
* Crash-landed ship is in there now. It's one that came with its own kind of "pedestal" in terms of a mesh representing soil it plowed through. With was beautiful but obviously just interface well with the desert and would require a plinth. I went with the idea of placing the ship and debris directly into the desert in this case since it's an object that seems able to exist in situ like that? It's quite beautiful. I do feel sorry about the loss of the soil texture, but what am I gonna do.
* Okay Moon Base 2030 might be a bust. When I bought it my actual concern was size - that it would be too massize, but that's not it at all. The problem is that although it's a cool model with interesting interior spaces and so on, it is no way ready for someone to experience. Notably there are no Mesh Colliders, but also there's just no way to access some of the internal spaces which make it feel a bit dumb to include it? Like it's semi interesting that there are things you couldn't see, but only semi and not an amazing experience to look at. I may just have to eat that cost and go with the doors - eating a few bad buys isn't the end of the world, it's the way it is. HMMMMM! Why isn't the world perfect?

# 27-01-2022

* OKAY. I got the crash-landed ship reinstalled in a way I find satisfying. Specifically I hovered in the air, attached mesh colliders and rigidbodies, then ran the game, let physics crash it down realistically, then copied its live instance and replaced the prefab with it, removing the rigidbodies. The effect being that you get to keep the transform after physics. This is all thanks to Paolo Pedercini (Molleindustria) letting me know this trick on Twitter. I'm grateful as I think this is a nice and honest way to situate the ship as "crashed" without being beholden to its ((admittedly lovely)) terrain extra. This probably would have been really useful for the prototyping materials too, but what's done it done.
* So, onto the Sci-Fi Doors.
* Well I've added them and they are one of the best things yet. They have an automatic opening/closing script based on proximity and I've put them in the obvious formation of one after the next in sequence so you get a kind of Maxwell Smart effect of passing through different doors on your way to nowhere - plinth at the start. They really are well made and lovely. Great combination with the crashlanded ship which is so situated - these are so perfectly artificial in the desert. Had to make very minimal pedestals to align them with the desert floor but even that's quite a nice touch.
* Oh by the way I compiled the game yesterday - fearing the worst, that it wouldn't even work - and it does actually work and run but it's already 5 GB! It zips to 2.4 GB or something but it's certainly uh... my biggest game. Yeah.
* Next up is the final Environments category which I think should begin steering me clear of ultramassive stuff. Props and then vehicles close it out (although there are tons of categories to deal with in each). I'm worried that the cartoon town will be too fucking big, so I may not go that way. The cinema is quite excellent so maybe that?

# 28-01-2022

* Ah and next is MOGADISHU LIGHTHOUSE! Buuuut... how big is it because I'm genuinely starting to worry about the size of the thing. But should that be a factor? And it's kind of unfair if it's a burden at the end so that it undue effects later assets if I start curating for size. HMM.
* Okay well it's in an it's fucking great, even has its mesh colliders on. My avatar is a bit... short in terms of experiencing it? So now we have some scale conflicts between things like Wild West town, Torture chamber, and Dungeon, and the lighthouse to potentially resolve with some avatar/asset scaling. Will have to think about the best approach for that. ANyway the lighthouse itself is just what I wanted it to be and I could not be happier with it. Love love love.
* Chucked in Easy Block as the other Urban environment. Looks solid, like actually just a solid block of building. Pretty funny. I guess you could tile it with rotation to create some passing resemblance to some of a city? Certainly it's urban.
* By my reckoning I'm actually exactly half-way through?! The desert is definitely *not* full which is interesting. But if you add the same amount again it might be quite well populated?

# 31-01-2022

* I installed the Fossils pack but I guess I forgot to say anything. Very straightforward and, most wonderfully, the fossils come as a museum exhibit on marble pedestals of their own which is so lovely. They look truly nice in the environment.
* Plus next up is bleachers.

# 02-02-2022

* Okay now it's really now. Bleachers time.
* They went in fine. Nothing special to say...

# 03-02-2022

* Umbrella PRO! Professional umbrella. Makes me think of Magritte. And they look nice. Used the rigid body trick to position them and it works a charm. Life changer really and makes me wonder if I should have been doing this with everything in the first place? Or anything kind of "loose"? I dunno, it's also okay to embed some things in the sand because it makes it feel like they've been there a while. it's all okay.
* Clothes Hanger. A reminder of Duchamp, so that's terribly clever of me isn't it. Installed them on a wall, first instance of that rather than just dumping them on the ground. They look nice, and I like them in combination with the umbrellas I think. All's well.

# 04-02-2022

* Making efforts. Got the bandana face masks in. They are as good as I hoped and come with effectively "styrofoam heads" that they're modelled on. I really do love it when there's this instinct with a creator to do a more museum-oriented display rather than something more contextual. They look great.
* Now looking at Low Poly Hats #2. The demo scene has them floating in the air in a vertical grid, which is tricky. I don't think I can mounter them to a wall in this way because they have different depths. If I want to place them on a horizontal plinth they'll be okay, but perhaps some of the inner ones won't quite be visible? I could dump them in a pile, but does that feel disrespectful? yes it does given they bothered to grid them - they clearly want each one to be distinct etc. So probably a horizontal plinth does make the most sense, hmmm, will try that. Maybe need some custom rotation stuff to make them sit ""realistically"? I don't think the physics trick works because they'll roll out of the grid slot.
* Hmmm I think every hat will need a custom rotation, which is fine. I'll finish that off tomorrow then I suppose.

## 15-02-2022

* Jesus how the fuck did I lose 11 days exactly? Essentially all last week. It was just A Week I suppose. DHC on Monday, teaching stuff, millions of meetings, etc. Yeah fair enough fair enough.
* Well I rotated the hats and sat them in their places and they look lovely.
* Next up are Slavic Shields which are beautiful and I think because of their shape I can lean them up against a dune which will be a nice display option for them.
* While I'm thinking about it in case I didn't say it earlier on, the fact the game is kind of HUGE (5 GB or whatever) is... sort of cool in the sense that's it's a weird underlying arbiter of quality? A "big game" is a "good game". I think about downloading GTA IV the other day for instances. Took an age because there's so much data and data=quality?
* Alright Slavic Shields are in. Something I'm noticing that will possibly be a pain in my ass is the directional light and its relationship to differently positioned assets in the desert. The Slavic Shields have their "backs to the sun" which means the more important details on the front are somewhat in shadow. But changing it to suit one thing will inevitably change it adversely for another. Whatchagonna do? It's the sun. Oh wait you could just move the sun. Yeah that does make a degree of sense. Some kind of fast but not too fast day night cycle? Maybe a little quicker in the night? Or no night? Have to think about that.
* Next is the wonderfully named "Ultimate Hat: Knight". I love the idea of calling a knight's helmet a hat. It's about as underwhelming as you might imagine. Which is good? I'm already thinking to myself of future variations with ideas like "small things big" and "big things small" and "everything the same size" and so on. Lots of possibilities for displaying and redisplaying these elements to ask different questions. This collection ends up being a kind of corpus for "data analysis" and "data visualization"???? Love that.

## 16-02-2022

* Been a tiny bit slack on the curation commentary here. Put some fridges in the desert with no difficulty and they look appropriately funny. Especially since one of them has its door open. Teehee.
* Then I bought a retro computer before realizing that it was made by the same creator (openplay) which by my current rules means I can't use it. Asshat. Well, I have it for a future project I suppose. It's a classic object.
* So now I've bought a microwave instead which is maybe more funny anyway, especially facing off against the fridges. May want to similarly open a door? Does it have an interior?
* Microwave has no interior and no ability to open its door. Interesting limitation that clearly devalues it. Some value exists in the structural properties of a mesh. Still looks very funny out there baking in the sun though so no complaints from me.

## 17-02-2022

* Hello. What's next? More props more props. I'm actually getting every so slightly nervous that there are not ENOUGH things for the desert to feel the right kind of full/not-full. We'll see though, still quite a few to go.
* Well chain-link fence is in now and it's a pretty busted/not amazing asset, which is of course good to have. They are totally flat and only have one side for the actual chainlink part so you can't even see most of the fence from one side. It was quite satisfying to fence of an area with them though. One drag being that I haven't currently got consistency about which way different chunks of the fence point, so there's most of the fence aimed inward, but two sections aimed outward. What is the more important view in terms of seeing it? Probably the outer shell should actually be the one that's most visible right, since that's likely the first thing you see. Then you go inside and notice that the links have only one face. There's an odd "puzzle" vibe to it almost, like realizing you can walk through because you're on the invisible side face of something.
* Went back in and realized that for almost all the fencing I could duplicate each module and spin it 180 to create a visible back-side. However somewhat ridiculously it doesn't work for the damaged fence models since they aren't symmetric either within themselves of with each other. Unless I can do a negative scale? I'll try quickly... well whaddya know, I can do that and it worked. So there's some flexibility there at least. Really does feel like a poorly developed model. Just whipped up in software without a lot of thought because a quick eye test and then thrown onto the store and charged for. Still, interesting experience for me and quite funny to have fences that don't work but still define a space.
* Added the sunbeds. I'd initially had a thought that I wouldn't and would do air conditioners or something for the comedy of that + the idea that something like sunbeds might be in furniture. BUT they *are* an exterior prop in a reasonable way *and* when I looked at the promo image it's just too gorgeous to think about all these sunbeds out in the desert. Also it comes with a display block of sand (which is funny in the context) and it makes me think of J. G. Ballard in a way, post apocalyptic holidaying. And it turns out that seen up close the beds are *very beautiful* all on their own, like one of the more gorgeous things in the set.
* The beds also make me think of making some games that are just assembled vignettes with some audio, perhaps, or other narration. They're so lovely and it would be a really interesting challenge for me to do some story telling via this corpus I have I suspect. Both by assemablage, but also by coding them, fucking with them, getting weird. But with story at the heart of it. So that was a big win for this morning.

## 22-02-2022

* Well it's been a couple of days since I was at this. Had a big interview day on Monday so no time. However here we are.
* Just installed the low poly fast food and the fruit pack. The idea there was another realism/low poly comparison. I especially like the fruit pack because there's one exemplar that comes in a bowl and is just nicely referent to the idea of a still life. Also learned after the fact that every fruit has a ROTTEN VERSION which is awesome. 
* The fast food is nice enough, if not a lot to write home about. It did come with a funny floor texture under it that I think has the key textures being used on the foods as a kind of palette example or handy tool? Anyway it was a nice feature that I included as part of the pedestal.
* So a bit uneventful but nice.

## 16-09-2022

Hairy notes written as I try to triage file size by swapping out a few of the biggest culprits...

* Animal pack deluxe v2: https://assetstore.unity.com/packages/3d/characters/animals/animal-pack-deluxe-v2-144071 729 MB

* √ https://assetstore.unity.com/packages/3d/characters/animals/reptiles/t-rex-model-49824 370 MB

* √ https://assetstore.unity.com/packages/3d/characters/robots/brute-robot-173508 329 MB

* √ Small Town America Super Store: https://assetstore.unity.com/packages/3d/environments/small-town-america-super-store-57064 396 MB

* √ Medieval Dungeon & Torture Chamber: https://assetstore.unity.com/packages/3d/environments/dungeons/medieval-dungeon-torture-chamber-131181 402 MB

* √ HQ Medieval forge: https://assetstore.unity.com/packages/3d/environments/fantasy/hq-medieval-forge-150002 928 MB

* √ Station v1: https://assetstore.unity.com/packages/3d/environments/industrial/station-v1-103418 765 MB

* Fruit with LODs: https://assetstore.unity.com/packages/3d/props/food/fruit-with-lods-160541 145.6 MB

* Guns Pack: https://assetstore.unity.com/packages/3d/props/guns/guns-pack-53729 (5) 359.7 MB

* Plants pack: https://assetstore.unity.com/packages/3d/vegetation/plants-pack-177792 129.2 MB

10/88 (0.11) 4.5/17 GB (0.26)

Of these if I were killing some darlings it would be

* Forge
* Station v1
* Guns pack
* T-Rex Model

And maybe

* Brute robot
* Torture dungeon

6/88 (0.07) totalling 3.2/17 GB (0.19) (average asset size is 193MB, without these it's 168.1MB)

Anyway it seems like an obvious call. Not least because a bunch of these aren't necessarily thaaaat amazing?

# ToolMan

This is a project for the Unity learn. junior programmer module.
It is supposed to showcase usage of OOP principles.
For example there was a requirement of showing inheritance

# My idea.
After pondering for a little bit, thinking of something i could i apply OOP inheritance that wasn't animals (harder than i thought to be honest.),
i thought of tools. Tools have so many kinds of tools, and they all have different traits.

## Tool traits
Tools have different traits of course.
For example a screwdriver and a hammer are both handheld tools, yet they fill different purposes and in the real world you want to have the right tool for the job. Yes if you're persisten enough anythings a hammer of course! (TODO: let all tools be used as hammers)
You cant screw in a screw with a hammer and neither can you hammer in a nail with a screwdriver, yet they both usually share some traits like:
- The need to be held in one hand.
- Physical or manual labor (compared to say an electric screwdriver).

## Inheritance and Composition

After having committed to the idea of building OOP principles out of tools, i of course had a lot of ideas coming to me randomly, until i came upon [GameDevBeginners Composition](https://gamedevbeginner.com/how-to-use-script-composition-in-unity/),
and one of the things which made me start to ponder more over, how to implement a good tool system with inheritance i read this part:
> A class can only inherit from one base class at a time. Which means that, if you try to put too much into it, you may start to run into a situation where not all of the objects that inherit from the base class can use its functionality.

Which seems like it's a better idea for atleast tool for inheritance, because not long after i had the thought of what if i want to implement a dev tool for myself later on like a swizz army knife?

Expanding on composition from GameDevBeginner:
> Instead of being based on a particular type, composition describes what an object has or can do instead.
> 
> For example
>>An object that can take damage,
>>
>>An object that can be selected,
>>
>>An object that can be moved.

Back to the tool examples we could look at the objects, we're trying to use our tools on.
They too need to have different traits of course
For example:

A plank off wood can be:
  -Screwed
  -Nailed
  -Lots of other stuff like cutting, gluing but for the sake of the example we'll keep the list short.
which are both actions you can use a hammer and a screwdriver for. 

But say you were working on a car, a hammer (unless you're Jeremy Clarkson) is usually a tool that should be put at the bottom of the toolbox.
Because if you take a hammer and start banging away on the screws or nuts on the car you would probably just damage the car. Whereas with a screwdriver you can disassemble it without doing damage to the car. 
  



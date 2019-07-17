# AllTheWordsOfTheWorld
A simple application for storing and revising languages
This readme discusses two things:
   1.  The application itself (what is it, how it works and also lots of question marks about the design)
   2.  Why I've put it on open GitHub and what I hope from it.
1. The Application
==================
This is a simple application to hold words and expressions, as you learn them.
I'm a French speaker at about B2 level and I don't find using a physical notebook very helpful.  As I read books or use language learning resources, I've tended to capture vocab in Word documents - but that means they're all over the place and difficult to revisit.  So, I decided to build something that will capture the data as I need it.  This is it.
The main part of the app does exactly that.
I've grouped words and expressions together under **keywords**.
The main screen has a table of entries (in the bottom half) and a variety of actions managed by buttons (top left half).
When one section (or keyword group) is complete and the user starts a new group, the previous one is stored in memory (but not yet physically saved).
So, saving all keyword groups in memory can be done at any point or automatically, when closing the application.
This means that the various button activities can be broken into three logical groupings:
  a) manipulating an individual table - either the existing one, a previously stored one or a new one;
  b) working with the keywords in memory (the **Store**)
  c) saving or loading previously saved collections.
I've started on a second element which is presenting the words and expressions in a form that is useful for testing.

Note: I know that there are loads of flashcard utilities out there that would probably do all this and better.  My reasons for "rolling my own" are complex.

2. Why GitHub?
==============
Partly as a way of putting a toe into the GitHub water and partly because I'm genuinely interested in sharing the project.  So, if this takes your fancy, let me know.
In particular, it uses the following elements of C# in Visual Studio:
 - Windows Forms (I dabbled with WPF but, unless you specifically want the graphics benefits, I really couldn't see the point)
 - Data View Grid without being bound to a data source
 - Classes as a basic "linked list"
 - real-time creation of controls
 
 3. Questions, Prevarication and Future Direction
 ================================================
 a) I guess the whole thing.  It could be seen as a kind of initial stab at a proto-type.  Is there a completely different approach that would achieve the same end in a better way?
 b) The use of buttons.  Initially this seemed a good idea and more immediate than menus but I ended up with a lot more than I envisaged.  Would it be better to use Context Menus?  (That would be easy enough.)  Or, even, a straight app menu?  Conversely, buttons make keyboard control fairly easy: is there an even better keyboard-based control approach?
 c) Accents and the like.  I've kind of plonked a collection of letters with extras but it looks ugly to me and having so many can make them a little difficult to navigate.  Is there a better way to be multi-language friendly.  (Note: I've managed text using UTF-8.)  This can be a complex question: focusing on languages like French or Spanish is relatively easy but if we moved to Ancient Greek (for example) there are vastly more variations and is better handled programmatically - but this would mean a seperate module for each comparable language.  Hebrew (and, presumably, Arabic) would arguably be easier because Unicode combination characters could be used - but still a bit more complex than French.  As for Chinese, Korean, etc - well, I have no expertise.
 d) Testing.  Obviously, I know the kind of things this would require: e.g.
    - confirming right or wrong;
    - scoring and remembering scores;
    - focusing presentation on earlier errors.
    I didn't really want to get into any of that: this is for more advanced learners of a language and I think these strategies are both less interesting to such learners and extremely difficult to implement effectively.  However, the basic testing process might well do with a makeover.
    
So, there you have it.  If you think you can add anything or are simply interested in joining in (even use it as a base to improve your knowledge of C#), then feel free.

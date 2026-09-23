
| Course Title | C# Programming I |

| Course Code | CA242 |

| Department | Computer Application |

| Faculty | Computer & Information Technology |

| University | Jamhuriya University of Science & Technology |

| Academic Year | 2026 |

| Semester | IV |

| Student | Abdikarim Mohamed Salad |


# ASSIGMENTS
c# programming language

# Starting Out with Visual C# (Gaddis, 6th Edition)

## Chapter 1: Introduction to Visual C#

- Object: a program component with data (properties) and operations (methods).
- Control: a visible object in a GUI (Label, Button, TextBox). A class describes a type of object.
- .NET: a collection of classes for building Windows programs. Visual Studio is the IDE.
- Main windows: Designer, Solution Explorer, Properties, Toolbox.
- Project vs Solution: a project is one application; a solution is a container for projects.
- Naming controls: start with a letter or `_`, no spaces, use camelCase (`showDayButton`).
- Code structure: Namespace ⟶ Class ⟶ Method. GUI apps are event-driven.
- Common statements:

C#
MessageBox.Show("Hello World");
answerLabel.Text = "Result";
this.Close();          // close the form


- Comments: // line and /* block */.
- Errors: syntax errors show a red wavy line; wrong statement order causes logic errors.


## Chapter 2: Processing Data

Variables and types

| Type | Use | Example |
|---|---|---|
| `string` | Text | `"Hello"` |
| `int` | Whole numbers | `40` |
| `double` | Fractions | `87.6` |
| `decimal` | Money (literal ends with `m`) | `28.75m` |


Calculations
- Operators: + - * / % . Integer division: 7 / 3 = 2 ; use (double)x / y for 2.33.
- `double` and `decimal` cannot be mixed in one operation.

Input and output
- TextBox text is a string.
 Convert with int.Parse, double.Parse, decimal.Parse.


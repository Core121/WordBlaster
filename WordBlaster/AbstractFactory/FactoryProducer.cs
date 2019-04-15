using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WordBlaster.Dynamic_Linkage;

namespace WordBlaster.AbstractFactory
{
    class FactoryProducer
    {
        public FactoryIF getFactory(int level)
        {
            if (level.Equals(1))
            {
                return new LevelOneFactory();
            }
            else if (level.Equals(2))
            {
                return new LevelTwoFactory();
            }
            else if (level.Equals(3))
            {
                return new LevelThreeFactory();
            }
            else if (level.Equals(4))
            {
                return new LevelFourFactory();
            }
            else if (level.Equals(5))
            {
                return new LevelFiveFactory();
            }
            else
            {
                try
                {
                    LevelPlayer player = LevelPlayer.getInstance();
                    string dlevel = player.getFile();
                    String code;
                    String line;
                    //Pass the file path and file name to the StreamReader constructor

                    StreamReader sr = new StreamReader(dlevel);

                    //Read the first line of text
                    line = sr.ReadLine();
                    code = line;
                    //Continue to read until you reach end of file
                    while (line != null)
                    {
                        //Read the next line
                        line = sr.ReadLine();
                        code = code + "\n" + line;
                    }

                    //close the file
                    sr.Close();

                    Microsoft.CSharp.CSharpCodeProvider provider = new Microsoft.CSharp.CSharpCodeProvider();
                    ICodeCompiler compiler = provider.CreateCompiler();
                    System.CodeDom.Compiler.CompilerParameters compilerparams = new CompilerParameters();
                    compilerparams.GenerateExecutable = false;
                    compilerparams.GenerateInMemory = true;
                    compilerparams.ReferencedAssemblies.Add("System.dll");
                    compilerparams.ReferencedAssemblies.Add("System.Core.dll");
                    compilerparams.ReferencedAssemblies.Add(typeof(Program).Assembly.Location);
                    CompilerResults results = compiler.CompileAssemblyFromSource(compilerparams, code);
                    Assembly compiled = null;
                    if (results.Errors.HasErrors)
                    {
                        StringBuilder errors = new StringBuilder("Compiler Errors :\r\n");
                        foreach (CompilerError error in results.Errors)
                        {
                            errors.AppendFormat("Line {0},{1}\t: {2}\n",
                                   error.Line, error.Column, error.ErrorText);
                        }
                        throw new Exception(errors.ToString());
                    }
                    else
                    {
                        compiled =  results.CompiledAssembly;
                    }
                    int last = dlevel.LastIndexOf('\\');
                    last += 1;
                    Type type = compiled.GetType("WordBlaster.AbstractFactory." + dlevel.Substring(last, (dlevel.Count()-last-4)));
                    FactoryIF dynlvl = (FactoryIF)Activator.CreateInstance(type);
                    return dynlvl;
                }
                catch (System.TypeLoadException e)
                {
                    Console.WriteLine("Could not load file, starting normally...");
                    return new LevelOneFactory(); //if we could not load it in just start normally
                }
            }
        }

    }
}

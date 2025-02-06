import clr,os
maths_dll_lib_path=os.path.abspath("mathsLibrary.dll")
clr.AddReference(maths_dll_lib_path)
from MathLibrary import MathOperations as mp
print(mp.Add(2,4))


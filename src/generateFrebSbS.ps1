#script to merge the AdvancedDataGridView.dll and the FrebIng.exe into FrebSbS.exe
#.\generateFrebSbS.ps1 -DebugVersion $true  -> will generate Debug Version
#.\generateFrebSbS.ps1 -DebugVersion $False -> will generate Release version
#.\generateFrebSbS.ps1                      -> will generate Release version

param (
    [Parameter()]
     [bool] $DebugVersion
)


switch ($DebugVersion) {
  $true {
  $cdPath = $PSScriptRoot+"\FrebIt\bin\Debug"
  $IlMergeFullPath = $PSScriptRoot+"\tools\ILMerge.exe"
  $SecondPart = " /target:winexe /out:FrebSbs.exe FrebIng.exe AdvancedDataGridView.dll"
  $FullCommand = $IlMergeFullPath+$SecondPart
  cd $cdPath
  Invoke-expression $FullCommand
  cd ..\..\..
       "You have build the Debug version of FrebSBS and using the command:"
       $FullCommand 
       "The FinalExe can be found at:"
       $PSScriptRoot+"\FrebIt\bin\Debug\FrebSbS.exe"
  }
  Default {
  $cdPath = $PSScriptRoot+"\FrebIt\bin\Release"
  $IlMergeFullPath = $PSScriptRoot+"\tools\ILMerge.exe"
  $SecondPart = " /target:winexe /out:FrebSbS.exe FrebIng.exe AdvancedDataGridView.dll"
  $FullCommand = $IlMergeFullPath+$SecondPart
  cd $cdPath
  Invoke-expression $FullCommand
  cd ..\..\..
       "You have build the Release version of FrebSBS and using the command:"
       $FullCommand 
       "The FinalExe can be found at:"
       $PSScriptRoot+"\FrebIt\bin\Release\FrebSbS.exe"
  }
}
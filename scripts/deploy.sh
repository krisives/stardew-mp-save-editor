cd Stardew.MPSaveEditor
dotnet publish -c Release -r win10-x64 -o $TRAVIS_BUILD_DIR/releases/Stardew.MPSaveEditor
zip -r $TRAVIS_BUILD_DIR/releases/Stardew.MPSaveEditor-$TRAVIS_BUILD_ID.zip ${TRAVIS_BUILD_DIR}/releases/Stardew.MPSaveEditor

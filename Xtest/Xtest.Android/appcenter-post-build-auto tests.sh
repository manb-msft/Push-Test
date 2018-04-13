ls $APPCENTER_OUTPUT_DIRECTORY
ls $APPCENTER_SOURCE_DIRECTORY
ls $BUILD_BINARIESDIRECTORY
appcenter test run uitest --app "AndroidOrg/AndrXam" --devices "AndroidOrg/test" --app-path $APPCENTER_OUTPUT_DIRECTORY/com.companyname.Xtest.apk  --test-series "master" --locale "en_US" --build-dir $APPCENTER_SOURCE_DIRECTORY --token 7d4fb47ac52a244cd747afc5d41709a9c40b40d4 --uitest-tools-dir $APPCENTER_SOURCE_DIRECTORY/packages/Xamarin.UITest.2.2.3/tools
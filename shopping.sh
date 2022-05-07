#beef
#chicken
#milk
#eggs
#juice

echo "welcome to my shop"
running="true"

while [ "$running" == "true" ]
do

echo "press 0 to to exit"
echo "press the corrorponding number to select an item"
echo "1 beef"
echo "2 chicken"
echo "3 milk"
echo "4 eggs"
echo "5 juice"

read selection

if [ "$selection" == "0" ]
then
running = "false"
fi

if [ "$selection" == "1" ]
then
echo "beef is 10.99"
fi

if [ "$selection" == "2" ]
then
echo "chicken is 8.33"
fi

if [ "$selection" == "3" ]
then
echo "milk is 8.34"
fi

if [ "$selection" == "4" ]
then
echo "eggs is 3.45"
fi

if [ "$selection" == "5" ]
then
echo "juice is 5.34"
fi

done
 

 echo test
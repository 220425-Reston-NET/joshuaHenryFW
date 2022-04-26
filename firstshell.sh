echo "first file"
ten=10
five=5
thirteen=13

echo "===First If==="

if [ "$ten" -ge "$five" ]
then
echo "Greater!"
echo "$ten > $five"
fi

read test
 echo "===second if==="

if [ "$five" -ge "$ten" ]
then
echo "greater"
elif [ "$five" -le "$ten" ]
then 
echo  "lesser!"
echo "$five <  $ten"
fi

echo "===third if==="
if [ "$five" -ge "$ten" ]
then
echo "greater!"
echo "$five > $ten"
elif [ "$five" > "$thirteen" ]
then
echo "greater!"
echo " $five > $thirteen"
else 
echo "nothing matches"
fi
 
echo "===for loops==="
echo "===first loop==="
for number in 1 2 3 4 5
do
echo "Hello $number"
done

echo "===second loop==="
for i  in {1..10}
do
echo "$i"
done

echo "===while loop==="

while [ "$five" -le "$ten" ]
do
echo "lesser!"
five=$(($five+1))
echo "$five"
done

echo "what is your name"
read firstName

echo "hello $firstName, welcome"
fi





repeat = "true"
do
echo "welcome to shell scripting!"
echo "what do you want to do today?"
echo "enter 1 for adding tow numbers"
echo "enter 2 to exit"

read answer
if [ "$answer" == "1" ]
then
echo "give me number 1"
read num1
echo "give me number 2"
read num2
echo "the sum is $(($num1+$num2))"
elif [ "$answer" == 2]
then 
repeat="false"
else
echo "please enter"

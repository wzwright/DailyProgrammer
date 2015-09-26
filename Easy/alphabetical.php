<?php
// Letters in Alphabetical Order, 16 Aug 2015, https://www.reddit.com/r/dailyprogrammer/comments/3h9pde/20150817_challenge_228_easy_letters_in/
// This is one of the easiest challenges available on the subreddit; I wasn't feeling very adventurous today.

$file = fopen("input.txt", "r");
while(!feof($file)){
    $line = fgets($file);
    echo $line.(alphabetical($line)?" IN ORDER":" NOT IN ORDER");
}
fclose($file);

function alphabetical($s)
{
	$previous=-1;
	for($i=0;$i<strlen($s);$i++)
	{
		$current=ord($s[$i]);
		if($current>=$previous)
			$previous=$current;
		else
			return false;
	}
	return true;
}
?>
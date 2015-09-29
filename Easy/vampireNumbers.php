<?php
// Vampire Numbers, 28 Sep 2015, https://www.reddit.com/r/dailyprogrammer/comments/3moxid/20150928_challenge_234_easy_vampire_numbers/
// This runs pretty slow, which I suppose isn't much of a surprise. Could be hugely improved with some heuristics.
function vampire($length){
	$data=[];
	for($i=0;$i<$length/2;$i++)
	{
		$data[$i]=array();
		for($j=10;$j<100;$j++)
			$data[$i][]=array($j);
	}
	$arrays=allCombinations($data);
	foreach($arrays as $key=>$array)
	{
		for($i=1;$i<$length/2;$i++)
		{
			if($array[$i]<$array[$i-1]) continue 2;
		}
		$product=strval(array_product($array));
		if(substr($product,-2)!="00"&&count_chars($product, 1)==count_chars(join("",$array), 1)){
			echo array_product($array)."=".join("*",$array)."<br>";
		}
	}
}

function allCombinations($data){

    $result = array(array()); //this is crucial, dark magic.

    foreach ($data as $key => $array) {
        $new_result = array();
        foreach ($result as $old_element){
            foreach ($array as $element){
                if ($key == 0){
                    $new_result[] = $element;
                } else {
                    $new_result[] = array_merge($old_element,$element);
                }
            }
			//print_r($result);
			//echo "<br>";
        $result = $new_result;
        }
    }
    return $result;
}
?>
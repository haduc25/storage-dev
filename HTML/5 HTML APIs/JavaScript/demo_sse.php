<?php
header('Content-Type: text/event-stream');
header('Cache-Control: no-cache');

date_default_timezone_set("Asia/Ho_Chi_Minh");
$time = date("h:i:sa");
echo "data: The server time is: {$time}\n\n";
flush();

?>
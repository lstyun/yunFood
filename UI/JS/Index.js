$(function(){
	var click=0;
	var right=0; 
	var index=2;
	$('.video>div:first-child').click(function(){//左边按钮
		for(var i=0; i<5; i++){
			document.getElementsByTagName('video')[i].pause();
		}
		click+=1;
		if(click>=6)click=1;
		right=1;
		$('.video li:nth-of-type('+(((click+0)<=5) ? (click+0) : (click+0-5))+')').attr('class','video5');
		$('.video li:nth-of-type('+(((click+1)<=5) ? (click+1) : (click+1-5))+')').attr('class','video1');
		$('.video li:nth-of-type('+(((click+2)<=5) ? (click+2) : (click+2-5))+')').attr('class','video2');
		$('.video li:nth-of-type('+(((click+3)<=5) ? (click+3) : (click+3-5))+')').attr('class','video3');
		$('.video li:nth-of-type('+(((click+4)<=5) ? (click+4) : (click+4-5))+')').attr('class','video4');
		if(index==4)
		{
			index=0;
		}
		else
		{
			index+=1;
		}
		document.getElementsByTagName('video')[index].play();
	}
	)
	$('.video>div:last-child').click(function(){//右边按钮
		for(var i=0; i<5; i++){
			document.getElementsByTagName('video')[i].pause();
		}
		click-=1;
		if(click<=0)click=5;
		if(!right)click=4;
		right=1;
		$('.video li:nth-of-type('+(((click+0)<=5) ? (click+0) : (click+0-5))+')').attr('class','video5');
		$('.video li:nth-of-type('+(((click+1)<=5) ? (click+1) : (click+1-5))+')').attr('class','video1');
		$('.video li:nth-of-type('+(((click+2)<=5) ? (click+2) : (click+2-5))+')').attr('class','video2');
		$('.video li:nth-of-type('+(((click+3)<=5) ? (click+3) : (click+3-5))+')').attr('class','video3');
		$('.video li:nth-of-type('+(((click+4)<=5) ? (click+4) : (click+4-5))+')').attr('class','video4');
		if(index==0)
		{
			index=4
		}
		else
		{
		   index-=1;
		}
		document.getElementsByTagName('video')[index].play();
		}
	)
}
)
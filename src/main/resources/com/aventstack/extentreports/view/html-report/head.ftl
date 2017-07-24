<#assign timeStampFormat = config.getValue('timeStampFormat')>
<#assign cdn = config.getValue('cdn')>

<head>
	<meta charset='${ config.getValue('encoding') }' /> 
	<meta name='description' content='' />
	<meta name='robots' content='noodp, noydir' />
	<meta name='viewport' content='width=device-width, initial-scale=1' />
	<meta id="timeStampFormat" name="timeStampFormat" content='${timeStampFormat}'/>
	
	<link href='http://qm.corp.rs.com/teamapireport/css.css' rel='stylesheet' type='text/css'>
	<link href="http://qm.corp.rs.com/teamapireport/icon.css" rel="stylesheet">

	<#if cdn == 'extentreports'>
		<link href='http://qm.corp.rs.com/teamapireport/extent.css' type='text/css' rel='stylesheet' />
	<#else>
		<link href='http://qm.corp.rs.com/teamapireport/extent2.css' type='text/css' rel='stylesheet' />
	</#if>
	
	<title>${ config.getValue('documentTitle') }</title>

	<#if config.containsKey('css')>
	<style type='text/css'>
		${ config.getValue('css') }
	</style>
	</#if>
</head>

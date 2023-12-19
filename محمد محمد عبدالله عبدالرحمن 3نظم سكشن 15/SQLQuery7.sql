
select * from employee ;
 
 --ЧцЬЯ пс Чсуцйнэф ШубЪШЧЪ ЪвэЯ кф убЪШ ЧЭЯ уцйнэ Чснбк н 1 
select * from employee 
where убЪШ > some (select убЪШ from employee where боу_Чснбк = 'н1')

select * from employee 
where убЪШ > any (select убЪШ from employee where боу_Чснбк = 'н1')

 --ЧцЬЯ пс Чсуцйнэф ШубЪШЧЪ ЪвэЯ кф убЪШ пс уцйнэ Чснбк н 1
select * from employee 
where убЪШ > all (select убЪШ from employee where боу_Чснбк = 'н1')

--пцф оЧЦух ШЧсуцйнэф ЧсЪэ ЪвэЯ убЪШЧЪху кф уЪцги убЪШЧЪ Чсуцйнэф 
select * from employee 
where убЪШ >(select avg (убЪШ) from employee)

-- unionЧсЧЪЭЧЯ / intersect ЧсЪоЧик  /  except Чснбо

-- пцф оЧЦух ШЧгуЧС ЧсуЯф ЧсуцЬцЯ ШхЧ нбк Чц ЧсЪэ эЪна ШхЧ удбцк 

(select ЧсуЯэфх from нбк)
union 
(select ЧсуЯэфх from удбцк)


(select ЧсуЯэфх from нбк)
union all
(select ЧсуЯэфх from удбцк)


-- пцф оЧЦух ШЧгуЧС ЧсуЯф ЧсуцЬцЯ ШхЧ нбк цЧэжЧ эфна ШхЧ удбцк 
(select ЧсуЯэфх from нбк)
intersect
(select ЧсуЯэфх from удбцк)

-- пцф оЧЦух ШЧгуЧС ЧсуЯф ЧсуцЬцЯ ШхЧ нбк цсЧ эфна ШхЧ удбцк 
(select ЧсуЯэфх from нбк)
except
(select ЧсуЯэфх from удбцк)

select у.ЧсЧгу_ЧсЧцс , у.ЧсЧгу_ЧсЫЧфэ , б.цйэнх , б.ЧсубЪШ
from уцйн as у 
inner join уббЪШ as б
on у.боу_Чсуцйн = б.боу_Чсуцйн


select у.ЧсЧгу_ЧсЧцс , у.ЧсЧгу_ЧсЫЧфэ , б.цйэнх , б.ЧсубЪШ
from уцйн as у 
left join уббЪШ as б
on у.боу_Чсуцйн = б.боу_Чсуцйн


select у.ЧсЧгу_ЧсЧцс , у.ЧсЧгу_ЧсЫЧфэ , б.цйэнх , б.ЧсубЪШ
from уцйн as у 
right join уббЪШ as б
on у.боу_Чсуцйн = б.боу_Чсуцйн

select у.ЧсЧгу_ЧсЧцс , у.ЧсЧгу_ЧсЫЧфэ , б.цйэнх , б.ЧсубЪШ
from уцйн as у 
full join уббЪШ as б
on у.боу_Чсуцйн = б.боу_Чсуцйн













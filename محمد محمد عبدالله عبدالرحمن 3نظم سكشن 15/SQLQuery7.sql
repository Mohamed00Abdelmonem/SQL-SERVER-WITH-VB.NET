
select * from employee ;
 
 --���� �� �������� ������� ���� �� ���� ��� ����� ����� � 1 
select * from employee 
where ���� > some (select ���� from employee where ���_����� = '�1')

select * from employee 
where ���� > any (select ���� from employee where ���_����� = '�1')

 --���� �� �������� ������� ���� �� ���� �� ����� ����� � 1
select * from employee 
where ���� > all (select ���� from employee where ���_����� = '�1')

--��� ����� ��������� ���� ���� �������� �� ����� ������ �������� 
select * from employee 
where ���� >(select avg (����) from employee)

-- union������� / intersect �������  /  except �����

-- ��� ����� ������ ����� ������� ��� ��� �� ���� ���� ��� ����� 

(select ������� from ���)
union 
(select ������� from �����)


(select ������� from ���)
union all
(select ������� from �����)


-- ��� ����� ������ ����� ������� ��� ��� ����� ���� ��� ����� 
(select ������� from ���)
intersect
(select ������� from �����)

-- ��� ����� ������ ����� ������� ��� ��� ��� ���� ��� ����� 
(select ������� from ���)
except
(select ������� from �����)

select �.�����_����� , �.�����_������ , �.����� , �.������
from ���� as � 
inner join ����� as �
on �.���_������ = �.���_������


select �.�����_����� , �.�����_������ , �.����� , �.������
from ���� as � 
left join ����� as �
on �.���_������ = �.���_������


select �.�����_����� , �.�����_������ , �.����� , �.������
from ���� as � 
right join ����� as �
on �.���_������ = �.���_������

select �.�����_����� , �.�����_������ , �.����� , �.������
from ���� as � 
full join ����� as �
on �.���_������ = �.���_������












